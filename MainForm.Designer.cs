namespace Web_VP_Touch
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
            this.toolStripNav = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMaximize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMinimize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.webView1 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStripNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripNav
            // 
            this.toolStripNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxAddress,
            this.toolStripButtonClose,
            this.toolStripButtonMaximize,
            this.toolStripButtonMinimize,
            this.toolStripButtonSettings,
            this.toolStripSeparator1,
            this.toolStripButtonRefresh,
            this.toolStripSeparator2});
            this.toolStripNav.Location = new System.Drawing.Point(0, 0);
            this.toolStripNav.Name = "toolStripNav";
            this.toolStripNav.Size = new System.Drawing.Size(800, 25);
            this.toolStripNav.TabIndex = 0;
            // 
            // toolStripTextBoxAddress
            // 
            this.toolStripTextBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxAddress.Name = "toolStripTextBoxAddress";
            this.toolStripTextBoxAddress.Size = new System.Drawing.Size(400, 25);
            this.toolStripTextBoxAddress.ToolTipText = "Address";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Image = global::Web_VP_Touch.Properties.Resources.window_close_32x32;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonClose.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClose.Text = "toolStripButton1";
            this.toolStripButtonClose.ToolTipText = "Close";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonMaximize
            // 
            this.toolStripButtonMaximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonMaximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMaximize.Image = global::Web_VP_Touch.Properties.Resources.window_maximize_32x32;
            this.toolStripButtonMaximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMaximize.Name = "toolStripButtonMaximize";
            this.toolStripButtonMaximize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMaximize.Text = "toolStripButton1";
            this.toolStripButtonMaximize.ToolTipText = "Maximize";
            this.toolStripButtonMaximize.Click += new System.EventHandler(this.toolStripButtonMaximize_Click);
            // 
            // toolStripButtonMinimize
            // 
            this.toolStripButtonMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMinimize.Image = global::Web_VP_Touch.Properties.Resources.window_minimize_32x32;
            this.toolStripButtonMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMinimize.Name = "toolStripButtonMinimize";
            this.toolStripButtonMinimize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMinimize.Text = "toolStripButton1";
            this.toolStripButtonMinimize.ToolTipText = "Minimize";
            this.toolStripButtonMinimize.Click += new System.EventHandler(this.toolStripButtonMinimize_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = global::Web_VP_Touch.Properties.Resources.Settings_32x32;
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSettings.Text = "toolStripButton1";
            this.toolStripButtonSettings.ToolTipText = "Settings";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::Web_VP_Touch.Properties.Resources.Refresh_32x32;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "toolStripButton1";
            this.toolStripButtonRefresh.ToolTipText = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(775, 553);
            // 
            // webView1
            // 
            this.webView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView1.CreationProperties = null;
            this.webView1.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView1.Location = new System.Drawing.Point(0, 28);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(800, 471);
            this.webView1.Source = new System.Uri("http://192.168.1.59/", System.UriKind.Absolute);
            this.webView1.TabIndex = 0;
            this.webView1.ZoomFactor = 1D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.webView1);
            this.Controls.Add(this.toolStripNav);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripNav.ResumeLayout(false);
            this.toolStripNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripNav;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripButton toolStripButtonMaximize;
        private System.Windows.Forms.ToolStripButton toolStripButtonMinimize;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView1;
    }
}

