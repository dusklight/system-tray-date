using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SystemTrayDate
{
	/// <summary>
	/// Main form for System Tray Date
	/// https://github.com/dusklight/system-tray-date
	/// </summary>
	public partial class MainForm : Form
	{
		#region Win32

		private const int WM_SYSCOMMAND = 0x0112;
		private const int SC_MINIMIZE = 0xf020;

		[DllImport( "user32.dll", SetLastError = true )]
		static extern bool DestroyIcon( IntPtr hIcon );

		#endregion

		#region Constants, Fields

		private NotifyIcon _trayIcon = new NotifyIcon();

		private bool _closingFormApproved = false;

		#endregion

		#region Constructor

		public MainForm()
		{
			InitializeComponent();

			// TODO: Noticed that PowerModeChanged is not always triggered.  Probably Windows issue, need to
			// investigate further, but now that SessionSwitch is added, it should be okay for the main use case.

			Microsoft.Win32.SystemEvents.PowerModeChanged += SystemEvents_PowerModeChanged;
			Microsoft.Win32.SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;

			_trayIcon.ContextMenuStrip = mnuTrayIconContextMenu;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Adds a log message to the log ListBox.  Timestamp is added to the log message.
		/// </summary>
		/// <param name="log"></param>
		private void AddLog( string log )
		{
			lstLog.SelectedIndex = lstLog.Items.Add( DateTime.Now.ToString( "MM/dd/yyyy HH:mm:ss" ) + ": " + log );
			lstLog.Refresh();
		}

		private void ShowForm()
		{
			if ( WindowState == FormWindowState.Minimized )
			{
				WindowState = FormWindowState.Normal;
			}
			ShowInTaskbar = true;
			Show();
			Activate();
		}

		private void HideForm()
		{
			ShowInTaskbar = false;
			Hide();
		}

		private void ExitApplication()
		{
			_closingFormApproved = true;
			Close();
		}

		private Configuration GetConfig()
		{
			return ( Configuration )pgrdConfig.SelectedObject;
		}

		#endregion

		#region Form Events

		private void MainForm_Load( object sender, EventArgs e )
		{
			AddLog( "Started." );

			_trayIcon.Click += _trayIcon_Click;

			Configuration config = new Configuration();
			pgrdConfig.SelectedObject = config;

			DrawDate();

			WindowState = FormWindowState.Minimized;
		}

		private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( _closingFormApproved )
			{
				Microsoft.Win32.SystemEvents.PowerModeChanged -= SystemEvents_PowerModeChanged;
				Microsoft.Win32.SystemEvents.SessionSwitch -= SystemEvents_SessionSwitch;
				_trayIcon.Dispose();
			}
			else
			{
				e.Cancel = true;
				HideForm();
			}
		}

		private void _trayIcon_Click( object sender, EventArgs e )
		{
			// TODO: This can be moved to MouseClick event, which has the MouseEventArgs as param type, but need to be tested for touch input.

			var mouseEventArgs = e as MouseEventArgs;

			if ( mouseEventArgs != null )
			{
				if ( mouseEventArgs.Button != MouseButtons.Right )
				{
					ShowForm();
				}
			}
			else
			{
				ShowForm();
			}
		}

		private void pgrdConfig_Validated( object sender, EventArgs e )
		{
			// TODO: Serialize config here?
		}

		private void pgrdConfig_PropertyValueChanged( object s, PropertyValueChangedEventArgs e )
		{
			DrawDate();
		}

		private void btnExit_Click( object sender, EventArgs e )
		{
			ExitApplication();
		}

		private void btnRefresh_Click( object sender, EventArgs e )
		{
			DrawDate();
		}

		private void mnuItemExit_Click( object sender, EventArgs e )
		{
			ExitApplication();
		}

		private void mnuItemSettings_Click( object sender, EventArgs e )
		{
			ShowForm();
		}

		private void btnClearLog_Click( object sender, EventArgs e )
		{
			lstLog.Items.Clear();
		}

		private void lnkGithub_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			System.Diagnostics.Process.Start( lnkGithub.Text );
		}

		#endregion

		#region Message Pump

		protected override void WndProc( ref Message m )
		{
			// Ahh good old Windows Message Pump...
			if ( m.Msg == WM_SYSCOMMAND )
			{
				if ( m.WParam.ToInt32() == SC_MINIMIZE )
				{
					// When minimizing, just hide the form.  But we also need to cancel the actual minimze operation,
					// otherwise the form will become absolute minimally sized window (e.g., just basically title bar).
					HideForm();
					m.Result = IntPtr.Zero;
					return;
				}
			}
			base.WndProc( ref m );
		}

		#endregion

		#region System Events

		private void SystemEvents_PowerModeChanged( object sender, Microsoft.Win32.PowerModeChangedEventArgs e )
		{
			AddLog( "PowerModeChanged: " + e.Mode.ToString() );
			if ( e.Mode == Microsoft.Win32.PowerModes.Resume )
			{
				DrawDate();
			}
		}

		private void SystemEvents_SessionSwitch( object sender, Microsoft.Win32.SessionSwitchEventArgs e )
		{
			AddLog( "SessionSwitch: " + e.Reason.ToString() );
			DrawDate();
		}

		#endregion

		#region Draw Date

		private void DrawDate()
		{
			// Uses TextRenderer, and not Graphics.DrawString.

			Configuration config = GetConfig();

			Bitmap bitmapText = new Bitmap( 16, 16 );
			Graphics g = Graphics.FromImage( bitmapText );

			IntPtr hIcon = IntPtr.Zero;

			var dateToDraw = DateTime.Now.Day.ToString();

			try
			{
				g.Clear( config.BackgroundColor );
				if ( config.AntiAliasEnabled )
				{
					g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
				}

				if ( config.DayOfWeekIndicatorEnabled && config.DayOfWeekOffset != 0 )
				{
					// If DayOfWeekIndicator is enabled, let's put some distance between the day and the indicator, so push up the text a little bit.
					// This means we can't use TextFormatFlags.VeriticalCenter, but more importantly, we also can't use HorizontalCenter because we can't
					// use the Rectangle overload.  We need to use the Point overload, which means we need to calculate the horizontal center manually.
					TextRenderer.DrawText(
						g,
						dateToDraw,
						config.Font,
						GetHorizontallyCenteredPoint( g, dateToDraw, config.Font, 16, 16, config.DayOfWeekOffset, TextFormatFlags.NoPadding ),
						config.Color,
						config.BackgroundColor,
						TextFormatFlags.NoPadding );
				}
				else
				{
					// This makes it pretty simple.  I was going to use MeasureWidth method to calculate the width of the text and center it, but
					// the overload with TextFormatFlags takes care of everything.
					TextRenderer.DrawText(
						g,
						dateToDraw,
						config.Font,
						new Rectangle( 0, 0, 16, 16 ),
						config.Color,
						config.BackgroundColor,
						TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding );
				}


				if ( config.BorderEnabled )
				{
					Pen pen = new Pen( config.BorderColor, config.BorderPixelSize );

					Point[] points =
					{
						new Point( 0, 0 ),
						new Point( 15, 0 ),
						new Point( 15, 15 ),
						new Point( 0, 15 ),
						new Point( 0, 0 )
					};

					g.DrawLines( pen, points );
				}

				if ( config.DayOfWeekIndicatorEnabled )
				{
					DrawWeekDayIndicator( g );
				}

				hIcon = bitmapText.GetHicon();

				_trayIcon.Icon = Icon.FromHandle( hIcon );
				_trayIcon.Visible = true;

				AddLog( $"Date drawn to tray: {dateToDraw}" );
			}
			finally
			{
				if ( hIcon != IntPtr.Zero )
				{
					DestroyIcon( hIcon );
				}

				bitmapText.Dispose();
				g.Dispose();
			}
		}

		private Point GetHorizontallyCenteredPoint( Graphics g, string s, Font f, int canvasWidth, int canvasHeight, int verticalOffset, TextFormatFlags textFormatFlags )
		{
			Size renderedSize = TextRenderer.MeasureText( g, s, f, new Size( canvasWidth, canvasHeight ), textFormatFlags );

			System.Diagnostics.Debug.WriteLine( renderedSize.ToString() );

			int centeredX = (canvasWidth - renderedSize.Width) / 2;
			int centeredY = ((canvasHeight - renderedSize.Height) / 2);

			System.Diagnostics.Debug.WriteLine( centeredX.ToString() );
			System.Diagnostics.Debug.WriteLine( centeredY.ToString() );

			return new Point( centeredX, centeredY - verticalOffset );
		}

		private void DrawWeekDayIndicator( Graphics g )
		{
			Configuration config = GetConfig();

			// Use small dots to indicate the weekday.
			Rectangle[] weekDayRectangles =
			{
				new Rectangle( 1, 14, 1, 1 ), // Monday
				new Rectangle(4, 14, 1, 1), // Tuesday
				new Rectangle(7, 14, 1, 1), // Wednesday
				new Rectangle(10, 14, 1, 1), // Thursday
				new Rectangle(13, 14, 1, 1) // Friday
			};

			Pen currentDayPen = new Pen( config.DayOfWeekCurrentDayColor, 1 );
			Pen otherDayPen = new Pen( config.DayOfWeekOtherDaysColor, 1 );

			g.DrawRectangles( otherDayPen, weekDayRectangles );

			// Now overwrite the current day with different pen for Saturday and Sundays (using two dots to denote them for now).
			if ( DateTime.Now.DayOfWeek == DayOfWeek.Saturday )
			{
				g.DrawRectangle( currentDayPen, weekDayRectangles[ 0 ] );
				g.DrawRectangle( currentDayPen, weekDayRectangles[ 1 ] );
			}
			else if ( DateTime.Now.DayOfWeek == DayOfWeek.Sunday )
			{
				g.DrawRectangle( currentDayPen, weekDayRectangles[ 3 ] );
				g.DrawRectangle( currentDayPen, weekDayRectangles[ 4 ] );
			}
			else
			{
				g.DrawRectangle( currentDayPen, weekDayRectangles[ ( int )DateTime.Now.DayOfWeek - 1 ] );
			}
		}

		#endregion

	}
}
