namespace Eclipse_Mod_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnModList = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.frmMainPanel = new System.Windows.Forms.Panel();
            this.lblFirstLaunchTip2 = new System.Windows.Forms.Label();
            this.lblFirstLaunchTip = new System.Windows.Forms.Label();
            this.lblDetectHome = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            this.navbarPanel.SuspendLayout();
            this.frmMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.titleBar.Controls.Add(this.button2);
            this.titleBar.Controls.Add(this.button1);
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(915, 26);
            this.titleBar.TabIndex = 0;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBar_Paint);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(860, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 25);
            this.button2.TabIndex = 99999;
            this.button2.TabStop = false;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(888, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 9999;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(365, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 25);
            this.lblTitle.TabIndex = 9999;
            this.lblTitle.Text = "Eclipse Mod Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.navbarPanel.Controls.Add(this.btnDonate);
            this.navbarPanel.Controls.Add(this.btnGitHub);
            this.navbarPanel.Controls.Add(this.btnClose);
            this.navbarPanel.Controls.Add(this.btnSettings);
            this.navbarPanel.Controls.Add(this.btnHome);
            this.navbarPanel.Controls.Add(this.btnModList);
            this.navbarPanel.Controls.Add(this.lblVersion);
            this.navbarPanel.Location = new System.Drawing.Point(0, 26);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(207, 458);
            this.navbarPanel.TabIndex = 1;
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDonate.FlatAppearance.BorderSize = 0;
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnDonate.ForeColor = System.Drawing.Color.Gray;
            this.btnDonate.Location = new System.Drawing.Point(101, 303);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(102, 42);
            this.btnDonate.TabIndex = 6;
            this.btnDonate.Text = "Donate";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGitHub.ForeColor = System.Drawing.Color.Gray;
            this.btnGitHub.Location = new System.Drawing.Point(0, 303);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(101, 42);
            this.btnGitHub.TabIndex = 5;
            this.btnGitHub.Text = "GitHub";
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(0, 384);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Exit Eclipse";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gray;
            this.btnSettings.Location = new System.Drawing.Point(0, 345);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(203, 39);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Gray;
            this.btnHome.Location = new System.Drawing.Point(0, 52);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnModList
            // 
            this.btnModList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnModList.FlatAppearance.BorderSize = 0;
            this.btnModList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModList.ForeColor = System.Drawing.Color.Gray;
            this.btnModList.Location = new System.Drawing.Point(0, 91);
            this.btnModList.Name = "btnModList";
            this.btnModList.Size = new System.Drawing.Size(203, 39);
            this.btnModList.TabIndex = 1;
            this.btnModList.Text = "Mods";
            this.btnModList.UseVisualStyleBackColor = false;
            this.btnModList.Click += new System.EventHandler(this.btnModList_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(-1, 432);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(204, 16);
            this.lblVersion.TabIndex = 0;
            this.lblVersion.Text = "Version: 0.0.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainPanel
            // 
            this.frmMainPanel.BackColor = System.Drawing.Color.DimGray;
            this.frmMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmMainPanel.BackgroundImage")));
            this.frmMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.frmMainPanel.Controls.Add(this.lblFirstLaunchTip2);
            this.frmMainPanel.Controls.Add(this.lblFirstLaunchTip);
            this.frmMainPanel.Controls.Add(this.lblDetectHome);
            this.frmMainPanel.Location = new System.Drawing.Point(203, 26);
            this.frmMainPanel.Name = "frmMainPanel";
            this.frmMainPanel.Size = new System.Drawing.Size(712, 457);
            this.frmMainPanel.TabIndex = 2;
            // 
            // lblFirstLaunchTip2
            // 
            this.lblFirstLaunchTip2.AutoSize = true;
            this.lblFirstLaunchTip2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstLaunchTip2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFirstLaunchTip2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLaunchTip2.ForeColor = System.Drawing.Color.Navy;
            this.lblFirstLaunchTip2.Location = new System.Drawing.Point(64, 376);
            this.lblFirstLaunchTip2.Name = "lblFirstLaunchTip2";
            this.lblFirstLaunchTip2.Size = new System.Drawing.Size(255, 15);
            this.lblFirstLaunchTip2.TabIndex = 2;
            this.lblFirstLaunchTip2.Text = "(Don\'t wanna see this anymore? Click me!)";
            this.lblFirstLaunchTip2.Click += new System.EventHandler(this.lblFirstLaunchTip2_Click);
            // 
            // lblFirstLaunchTip
            // 
            this.lblFirstLaunchTip.AutoSize = true;
            this.lblFirstLaunchTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstLaunchTip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFirstLaunchTip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLaunchTip.ForeColor = System.Drawing.Color.Navy;
            this.lblFirstLaunchTip.Location = new System.Drawing.Point(10, 355);
            this.lblFirstLaunchTip.Name = "lblFirstLaunchTip";
            this.lblFirstLaunchTip.Size = new System.Drawing.Size(362, 21);
            this.lblFirstLaunchTip.TabIndex = 1;
            this.lblFirstLaunchTip.Text = "<--- Configure Eclipse before using it!";
            this.lblFirstLaunchTip.Click += new System.EventHandler(this.lblFirstLaunchTip_Click);
            // 
            // lblDetectHome
            // 
            this.lblDetectHome.AutoSize = true;
            this.lblDetectHome.Location = new System.Drawing.Point(50, 444);
            this.lblDetectHome.Name = "lblDetectHome";
            this.lblDetectHome.Size = new System.Drawing.Size(0, 13);
            this.lblDetectHome.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(915, 483);
            this.Controls.Add(this.frmMainPanel);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Eclipse Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.titleBar.ResumeLayout(false);
            this.navbarPanel.ResumeLayout(false);
            this.frmMainPanel.ResumeLayout(false);
            this.frmMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Panel frmMainPanel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnModList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblDetectHome;
        private System.Windows.Forms.Label lblFirstLaunchTip;
        private System.Windows.Forms.Label lblFirstLaunchTip2;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Button btnGitHub;
    }
}

