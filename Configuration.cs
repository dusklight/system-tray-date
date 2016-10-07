using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SystemTrayDate
{
	/// <summary>
	/// Configuration class to store settings for the application.
	/// 
	/// TODO: Serialization.
	/// </summary>
	[Serializable]
	public class Configuration
	{
		#region Category: Date

		[Category( "Date" )]
		[Description( "The font used to display the date." )]
		[DefaultValue( typeof( Font ), "Consolas, 10pt, style=Bold" )]
		public Font Font { get; set; } = new Font( "Consolas", 10, FontStyle.Bold, GraphicsUnit.Point );

		[Category( "Date" )]
		[Description( "The color for the date." )]
		[DefaultValue( typeof( Color ), "ControlText" )]
		public Color Color { get; set; } = SystemColors.ControlText;

		[Category( "Date" )]
		[Description( "The background color for the icon." )]
		[DefaultValue( typeof( Color ), "Control" )]
		public Color BackgroundColor { get; set; } = SystemColors.Control;

		[Category( "Date" )]
		[Description( "Indicates whether anti-aliasing is enabled." )]
		[DefaultValue( true )]
		public bool AntiAliasEnabled { get; set; } = true;

		#endregion

		#region Category: Border

		[Category( "Border" )]
		[Description( "Indicates whether border is enabled." )]
		[DefaultValue( false )]
		public bool BorderEnabled { get; set; } = false;

		[Category( "Border" )]
		[Description( "The pixel size to use when drawing the border." )]
		[DefaultValue( 1 )]
		public int BorderPixelSize { get; set; } = 1;

		[Category( "Border" )]
		[Description( "The color for the border." )]
		[DefaultValue( typeof( Color ), "WindowFrame" )]
		public Color BorderColor { get; set; } = SystemColors.WindowFrame;

		#endregion

		#region Category: Week Day Indicator

		[Category( "Week Day Indicator" )]
		[Description( "Indicates whether Weekday Indicator is enabled." )]
		[DefaultValue( true )]
		public bool DayOfWeekIndicatorEnabled { get; set; } = true;

		[Category( "Week Day Indicator" )]
		[Description( "The color of the current day." )]
		[DefaultValue( typeof( Color ), "ControlText" )]
		public Color DayOfWeekCurrentDayColor { get; set; } = SystemColors.ControlText;

		[Category( "Week Day Indicator" )]
		[Description( "The color of other days." )]
		[DefaultValue( typeof( Color ), "ButtonShadow" )]
		public Color DayOfWeekOtherDaysColor { get; set; } = SystemColors.ButtonShadow;

		[Category( "Week Day Indicator" )]
		[Description( "The offset between the date and the Weekday Indicator." )]
		[DefaultValue( 1 )]
		public int DayOfWeekOffset { get; set; } = 1;

		#endregion

		#region Constructor

		public Configuration()
		{
		}

		#endregion

	}
}
