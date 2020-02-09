namespace Eclipse_Mod_Manager
{
    partial class SettingsPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtGameFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.foldBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.alertPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.lblGFNotSet = new System.Windows.Forms.Label();
            this.lblUnresIssues = new System.Windows.Forms.Label();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.lblSettingsOk = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.appearancePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAppearance = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEclipseSettings = new System.Windows.Forms.Label();
            this.chkTips = new System.Windows.Forms.CheckBox();
            this.lblSomeTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStrckNotInstalled = new System.Windows.Forms.Label();
            this.alertPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.appearancePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.ForeColor = System.Drawing.Color.Gray;
            this.btnSelectFolder.Location = new System.Drawing.Point(583, 27);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(122, 25);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtGameFolder
            // 
            this.txtGameFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGameFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGameFolder.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameFolder.ForeColor = System.Drawing.Color.Gray;
            this.txtGameFolder.Location = new System.Drawing.Point(-1, 27);
            this.txtGameFolder.Name = "txtGameFolder";
            this.txtGameFolder.ReadOnly = true;
            this.txtGameFolder.Size = new System.Drawing.Size(579, 25);
            this.txtGameFolder.TabIndex = 2;
            this.txtGameFolder.Text = "Select your game\'s folder";
            this.txtGameFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(583, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(334, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "View License";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alertPanel
            // 
            this.alertPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.alertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alertPanel.Controls.Add(this.lblStrckNotInstalled);
            this.alertPanel.Controls.Add(this.lblSettingsOk);
            this.alertPanel.Controls.Add(this.lblUnresIssues);
            this.alertPanel.Controls.Add(this.lblGFNotSet);
            this.alertPanel.Controls.Add(this.panel2);
            this.alertPanel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertPanel.Location = new System.Drawing.Point(281, 276);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(297, 137);
            this.alertPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblAlerts);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 23);
            this.panel2.TabIndex = 0;
            // 
            // lblAlerts
            // 
            this.lblAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblAlerts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlerts.Location = new System.Drawing.Point(-1, 0);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(298, 23);
            this.lblAlerts.TabIndex = 0;
            this.lblAlerts.Text = "Warnings";
            this.lblAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlerts.Click += new System.EventHandler(this.lblAlerts_Click);
            // 
            // lblGFNotSet
            // 
            this.lblGFNotSet.ForeColor = System.Drawing.Color.Maroon;
            this.lblGFNotSet.Location = new System.Drawing.Point(0, 40);
            this.lblGFNotSet.Name = "lblGFNotSet";
            this.lblGFNotSet.Size = new System.Drawing.Size(296, 17);
            this.lblGFNotSet.TabIndex = 1;
            this.lblGFNotSet.Text = "Game folder not set";
            this.lblGFNotSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnresIssues
            // 
            this.lblUnresIssues.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresIssues.Location = new System.Drawing.Point(0, 23);
            this.lblUnresIssues.Name = "lblUnresIssues";
            this.lblUnresIssues.Size = new System.Drawing.Size(296, 17);
            this.lblUnresIssues.TabIndex = 2;
            this.lblUnresIssues.Text = "The following issues need your attention";
            this.lblUnresIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGitHub.ForeColor = System.Drawing.Color.Gray;
            this.btnGitHub.Location = new System.Drawing.Point(455, 419);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(122, 31);
            this.btnGitHub.TabIndex = 6;
            this.btnGitHub.Text = "Eclipse GitHub";
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // lblSettingsOk
            // 
            this.lblSettingsOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSettingsOk.Location = new System.Drawing.Point(-1, 75);
            this.lblSettingsOk.Name = "lblSettingsOk";
            this.lblSettingsOk.Size = new System.Drawing.Size(296, 23);
            this.lblSettingsOk.TabIndex = 3;
            this.lblSettingsOk.Text = "All settings are valid";
            this.lblSettingsOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSettingsOk.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 10F);
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(3, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Theming";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // appearancePanel
            // 
            this.appearancePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.appearancePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appearancePanel.Controls.Add(this.panel3);
            this.appearancePanel.Controls.Add(this.button3);
            this.appearancePanel.Location = new System.Drawing.Point(3, 294);
            this.appearancePanel.Name = "appearancePanel";
            this.appearancePanel.Size = new System.Drawing.Size(240, 63);
            this.appearancePanel.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lblAppearance);
            this.panel3.Location = new System.Drawing.Point(-4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 23);
            this.panel3.TabIndex = 0;
            // 
            // lblAppearance
            // 
            this.lblAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblAppearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAppearance.Location = new System.Drawing.Point(3, 0);
            this.lblAppearance.Name = "lblAppearance";
            this.lblAppearance.Size = new System.Drawing.Size(240, 23);
            this.lblAppearance.TabIndex = 0;
            this.lblAppearance.Text = "Appearance";
            this.lblAppearance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.lblSomeTip);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panel4);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.alertPanel);
            this.mainPanel.Controls.Add(this.appearancePanel);
            this.mainPanel.Controls.Add(this.txtGameFolder);
            this.mainPanel.Controls.Add(this.btnGitHub);
            this.mainPanel.Controls.Add(this.btnSelectFolder);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(706, 451);
            this.mainPanel.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.lblEclipseSettings);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 23);
            this.panel4.TabIndex = 0;
            // 
            // lblEclipseSettings
            // 
            this.lblEclipseSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblEclipseSettings.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblEclipseSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEclipseSettings.Location = new System.Drawing.Point(0, 0);
            this.lblEclipseSettings.Name = "lblEclipseSettings";
            this.lblEclipseSettings.Size = new System.Drawing.Size(705, 23);
            this.lblEclipseSettings.TabIndex = 1;
            this.lblEclipseSettings.Text = "Eclipse Settings";
            this.lblEclipseSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkTips
            // 
            this.chkTips.AutoSize = true;
            this.chkTips.Location = new System.Drawing.Point(4, 29);
            this.chkTips.Name = "chkTips";
            this.chkTips.Size = new System.Drawing.Size(98, 17);
            this.chkTips.TabIndex = 7;
            this.chkTips.Text = "Disable Tips";
            this.chkTips.UseVisualStyleBackColor = true;
            this.chkTips.CheckedChanged += new System.EventHandler(this.chkTips_CheckedChanged);
            // 
            // lblSomeTip
            // 
            this.lblSomeTip.AutoSize = true;
            this.lblSomeTip.Location = new System.Drawing.Point(98, 55);
            this.lblSomeTip.Name = "lblSomeTip";
            this.lblSomeTip.Size = new System.Drawing.Size(385, 13);
            this.lblSomeTip.TabIndex = 10;
            this.lblSomeTip.Text = "You can hover your mouse over any option to see an explanation.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.chkTips);
            this.panel1.Location = new System.Drawing.Point(583, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 355);
            this.panel1.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 23);
            this.panel5.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Misc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStrckNotInstalled
            // 
            this.lblStrckNotInstalled.AutoSize = true;
            this.lblStrckNotInstalled.ForeColor = System.Drawing.Color.Maroon;
            this.lblStrckNotInstalled.Location = new System.Drawing.Point(40, 62);
            this.lblStrckNotInstalled.Name = "lblStrckNotInstalled";
            this.lblStrckNotInstalled.Size = new System.Drawing.Size(217, 13);
            this.lblStrckNotInstalled.TabIndex = 4;
            this.lblStrckNotInstalled.Text = "Stracker\'s Loader is not installed.";
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(712, 457);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.appearancePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtGameFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog foldBrowse;
        private System.Windows.Forms.Panel alertPanel;
        private System.Windows.Forms.Label lblGFNotSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.Label lblUnresIssues;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Label lblSettingsOk;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel appearancePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAppearance;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblEclipseSettings;
        private System.Windows.Forms.CheckBox chkTips;
        private System.Windows.Forms.Label lblSomeTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStrckNotInstalled;
    }
}
