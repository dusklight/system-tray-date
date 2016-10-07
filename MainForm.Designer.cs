namespace SystemTrayDate
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnRefresh = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.pgrdConfig = new System.Windows.Forms.PropertyGrid();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.lstLog = new System.Windows.Forms.ListBox();
			this.btnClearLog = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lnkGithub = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.mnuTrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuItemTitle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.mnuTrayIconContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(3, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(94, 35);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(301, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Show Day of the Month in the System Tray.\r\nVersion 0.1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(204, 3);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(94, 35);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit Application";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pgrdConfig
			// 
			this.pgrdConfig.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgrdConfig.Location = new System.Drawing.Point(0, 0);
			this.pgrdConfig.Name = "pgrdConfig";
			this.pgrdConfig.Size = new System.Drawing.Size(301, 308);
			this.pgrdConfig.TabIndex = 4;
			this.pgrdConfig.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgrdConfig_PropertyValueChanged);
			this.pgrdConfig.Validated += new System.EventHandler(this.pgrdConfig_Validated);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 52);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pgrdConfig);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(301, 445);
			this.splitContainer1.SplitterDistance = 308;
			this.splitContainer1.TabIndex = 5;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.lstLog);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.btnClearLog);
			this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.splitContainer2.Size = new System.Drawing.Size(301, 133);
			this.splitContainer2.SplitterDistance = 102;
			this.splitContainer2.TabIndex = 0;
			// 
			// lstLog
			// 
			this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstLog.FormattingEnabled = true;
			this.lstLog.HorizontalScrollbar = true;
			this.lstLog.Location = new System.Drawing.Point(0, 0);
			this.lstLog.Name = "lstLog";
			this.lstLog.ScrollAlwaysVisible = true;
			this.lstLog.Size = new System.Drawing.Size(301, 102);
			this.lstLog.TabIndex = 0;
			// 
			// btnClearLog
			// 
			this.btnClearLog.Location = new System.Drawing.Point(3, 2);
			this.btnClearLog.Name = "btnClearLog";
			this.btnClearLog.Size = new System.Drawing.Size(75, 23);
			this.btnClearLog.TabIndex = 0;
			this.btnClearLog.Text = "Clear Log";
			this.btnClearLog.UseVisualStyleBackColor = true;
			this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lnkGithub);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.panel1.Size = new System.Drawing.Size(301, 52);
			this.panel1.TabIndex = 6;
			// 
			// lnkGithub
			// 
			this.lnkGithub.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lnkGithub.Location = new System.Drawing.Point(0, 34);
			this.lnkGithub.Name = "lnkGithub";
			this.lnkGithub.Size = new System.Drawing.Size(301, 13);
			this.lnkGithub.TabIndex = 3;
			this.lnkGithub.TabStop = true;
			this.lnkGithub.Text = "https://github.com/dusklight/system-tray-date";
			this.lnkGithub.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnExit, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 497);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 46);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// mnuTrayIconContextMenu
			// 
			this.mnuTrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemTitle,
            this.toolStripSeparator2,
            this.mnuItemSettings,
            this.toolStripSeparator1,
            this.mnuItemExit});
			this.mnuTrayIconContextMenu.Name = "mnuTrayIconContextMenu";
			this.mnuTrayIconContextMenu.ShowImageMargin = false;
			this.mnuTrayIconContextMenu.Size = new System.Drawing.Size(140, 82);
			// 
			// mnuItemTitle
			// 
			this.mnuItemTitle.Enabled = false;
			this.mnuItemTitle.Name = "mnuItemTitle";
			this.mnuItemTitle.Size = new System.Drawing.Size(139, 22);
			this.mnuItemTitle.Text = "System Tray Date";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
			// 
			// mnuItemSettings
			// 
			this.mnuItemSettings.Name = "mnuItemSettings";
			this.mnuItemSettings.Size = new System.Drawing.Size(139, 22);
			this.mnuItemSettings.Text = "&Settings";
			this.mnuItemSettings.Click += new System.EventHandler(this.mnuItemSettings_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
			// 
			// mnuItemExit
			// 
			this.mnuItemExit.Name = "mnuItemExit";
			this.mnuItemExit.Size = new System.Drawing.Size(139, 22);
			this.mnuItemExit.Text = "E&xit";
			this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 543);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.Text = "System Tray Date";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.mnuTrayIconContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PropertyGrid pgrdConfig;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox lstLog;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button btnClearLog;
		private System.Windows.Forms.ContextMenuStrip mnuTrayIconContextMenu;
		private System.Windows.Forms.ToolStripMenuItem mnuItemSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
		private System.Windows.Forms.ToolStripMenuItem mnuItemTitle;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.LinkLabel lnkGithub;
	}
}

