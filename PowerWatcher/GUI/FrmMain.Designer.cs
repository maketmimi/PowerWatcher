namespace PowerWatcher.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkActivateStop = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbActionToTake = new System.Windows.Forms.ComboBox();
            this.TolActionToTake = new System.Windows.Forms.ToolTip(this.components);
            this.ImgMain = new System.Windows.Forms.ImageList(this.components);
            this.LibMalekGithub = new System.Windows.Forms.LinkLabel();
            this.BtnHide = new System.Windows.Forms.Button();
            this.NiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ChkRunOnStartup = new System.Windows.Forms.CheckBox();
            this.GbSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.GbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkActivateStop);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // ChkActivateStop
            // 
            this.ChkActivateStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkActivateStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkActivateStop.Checked = true;
            this.ChkActivateStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActivateStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkActivateStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChkActivateStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkActivateStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkActivateStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkActivateStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkActivateStop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkActivateStop.ForeColor = System.Drawing.Color.White;
            this.ChkActivateStop.Location = new System.Drawing.Point(112, 44);
            this.ChkActivateStop.Name = "ChkActivateStop";
            this.ChkActivateStop.Size = new System.Drawing.Size(155, 61);
            this.ChkActivateStop.TabIndex = 0;
            this.ChkActivateStop.Text = "Active";
            this.ChkActivateStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkActivateStop.UseVisualStyleBackColor = false;
            this.ChkActivateStop.CheckedChanged += new System.EventHandler(this.ChkActivateStop_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CbActionToTake);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action To Take";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make sure the selected action is supported by your system.\r\nOtherwise it will be " +
    "overriden";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbActionToTake
            // 
            this.CbActionToTake.BackColor = System.Drawing.Color.White;
            this.CbActionToTake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbActionToTake.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbActionToTake.ForeColor = System.Drawing.Color.Black;
            this.CbActionToTake.FormattingEnabled = true;
            this.CbActionToTake.Items.AddRange(new object[] {
            "Show alarm overlay",
            "Hibernate Mode (If Supported)",
            "Sleep Mode (If Supported)",
            "Shutdown"});
            this.CbActionToTake.Location = new System.Drawing.Point(80, 47);
            this.CbActionToTake.Name = "CbActionToTake";
            this.CbActionToTake.Size = new System.Drawing.Size(218, 28);
            this.CbActionToTake.TabIndex = 0;
            this.TolActionToTake.SetToolTip(this.CbActionToTake, "Choose what happens when the laptop is unplugged.");
            this.CbActionToTake.SelectedIndexChanged += new System.EventHandler(this.CbActionToTake_SelectedIndexChanged);
            // 
            // TolActionToTake
            // 
            this.TolActionToTake.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TolActionToTake.ToolTipTitle = "Info";
            // 
            // ImgMain
            // 
            this.ImgMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgMain.ImageStream")));
            this.ImgMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgMain.Images.SetKeyName(0, "MalekAltamimi_Logo.png");
            // 
            // LibMalekGithub
            // 
            this.LibMalekGithub.ActiveLinkColor = System.Drawing.Color.Black;
            this.LibMalekGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LibMalekGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibMalekGithub.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMalekGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LibMalekGithub.ImageIndex = 0;
            this.LibMalekGithub.ImageList = this.ImgMain;
            this.LibMalekGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LibMalekGithub.LinkColor = System.Drawing.Color.Black;
            this.LibMalekGithub.Location = new System.Drawing.Point(8, 281);
            this.LibMalekGithub.Name = "LibMalekGithub";
            this.LibMalekGithub.Size = new System.Drawing.Size(252, 27);
            this.LibMalekGithub.TabIndex = 2;
            this.LibMalekGithub.TabStop = true;
            this.LibMalekGithub.Text = "Developed by Malek Altamimi";
            this.LibMalekGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LibMalekGithub.VisitedLinkColor = System.Drawing.Color.Black;
            this.LibMalekGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LibMalekGithub_LinkClicked);
            // 
            // BtnHide
            // 
            this.BtnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHide.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHide.ForeColor = System.Drawing.Color.Black;
            this.BtnHide.Location = new System.Drawing.Point(360, 282);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(63, 27);
            this.BtnHide.TabIndex = 1;
            this.BtnHide.Text = "Hide";
            this.BtnHide.UseVisualStyleBackColor = false;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // NiMain
            // 
            this.NiMain.Icon = ((System.Drawing.Icon)(resources.GetObject("NiMain.Icon")));
            this.NiMain.Text = "Power Watcher";
            this.NiMain.Visible = true;
            this.NiMain.Click += new System.EventHandler(this.NiMain_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.MainPanel.Controls.Add(this.GbSettings);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.groupBox2);
            this.MainPanel.Location = new System.Drawing.Point(11, 6);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(412, 270);
            this.MainPanel.TabIndex = 0;
            // 
            // ChkRunOnStartup
            // 
            this.ChkRunOnStartup.AutoSize = true;
            this.ChkRunOnStartup.BackColor = System.Drawing.Color.Transparent;
            this.ChkRunOnStartup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRunOnStartup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ChkRunOnStartup.Location = new System.Drawing.Point(12, 40);
            this.ChkRunOnStartup.Name = "ChkRunOnStartup";
            this.ChkRunOnStartup.Size = new System.Drawing.Size(198, 25);
            this.ChkRunOnStartup.TabIndex = 0;
            this.ChkRunOnStartup.Text = "Run this app on startup";
            this.TolActionToTake.SetToolTip(this.ChkRunOnStartup, "Determines whether the application launches automatically upon user login.");
            this.ChkRunOnStartup.UseVisualStyleBackColor = false;
            this.ChkRunOnStartup.CheckedChanged += new System.EventHandler(this.ChkRunOnStartup_CheckedChanged);
            // 
            // GbSettings
            // 
            this.GbSettings.Controls.Add(this.ChkRunOnStartup);
            this.GbSettings.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GbSettings.Location = new System.Drawing.Point(8, 250);
            this.GbSettings.Name = "GbSettings";
            this.GbSettings.Size = new System.Drawing.Size(379, 79);
            this.GbSettings.TabIndex = 2;
            this.GbSettings.TabStop = false;
            this.GbSettings.Text = "Settings";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 313);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.BtnHide);
            this.Controls.Add(this.LibMalekGithub);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Power Watcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.GbSettings.ResumeLayout(false);
            this.GbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkActivateStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip TolActionToTake;
        private System.Windows.Forms.ComboBox CbActionToTake;
        private System.Windows.Forms.ImageList ImgMain;
        private System.Windows.Forms.LinkLabel LibMalekGithub;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.NotifyIcon NiMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox ChkRunOnStartup;
        private System.Windows.Forms.GroupBox GbSettings;
    }
}

