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
            this.label1 = new System.Windows.Forms.Label();
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
            this.alertPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eclipse MM Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.ForeColor = System.Drawing.Color.Gray;
            this.btnSelectFolder.Location = new System.Drawing.Point(574, 74);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(122, 23);
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
            this.txtGameFolder.Location = new System.Drawing.Point(19, 73);
            this.txtGameFolder.Name = "txtGameFolder";
            this.txtGameFolder.ReadOnly = true;
            this.txtGameFolder.Size = new System.Drawing.Size(549, 25);
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
            this.button1.Location = new System.Drawing.Point(633, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(528, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "View License";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alertPanel
            // 
            this.alertPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.alertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alertPanel.Controls.Add(this.lblSettingsOk);
            this.alertPanel.Controls.Add(this.lblUnresIssues);
            this.alertPanel.Controls.Add(this.lblGFNotSet);
            this.alertPanel.Controls.Add(this.panel2);
            this.alertPanel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertPanel.Location = new System.Drawing.Point(399, 239);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(297, 164);
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
            this.lblAlerts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlerts.Location = new System.Drawing.Point(-1, 0);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(296, 23);
            this.lblAlerts.TabIndex = 0;
            this.lblAlerts.Text = "Warnings";
            this.lblAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGFNotSet
            // 
            this.lblGFNotSet.ForeColor = System.Drawing.Color.Maroon;
            this.lblGFNotSet.Location = new System.Drawing.Point(-1, 40);
            this.lblGFNotSet.Name = "lblGFNotSet";
            this.lblGFNotSet.Size = new System.Drawing.Size(297, 14);
            this.lblGFNotSet.TabIndex = 1;
            this.lblGFNotSet.Text = "Game folder not set";
            this.lblGFNotSet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnresIssues
            // 
            this.lblUnresIssues.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresIssues.Location = new System.Drawing.Point(0, 23);
            this.lblUnresIssues.Name = "lblUnresIssues";
            this.lblUnresIssues.Size = new System.Drawing.Size(297, 16);
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
            this.btnGitHub.Location = new System.Drawing.Point(399, 409);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(123, 33);
            this.btnGitHub.TabIndex = 6;
            this.btnGitHub.Text = "Eclipse GitHub";
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // lblSettingsOk
            // 
            this.lblSettingsOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSettingsOk.Location = new System.Drawing.Point(74, 77);
            this.lblSettingsOk.Name = "lblSettingsOk";
            this.lblSettingsOk.Size = new System.Drawing.Size(146, 32);
            this.lblSettingsOk.TabIndex = 3;
            this.lblSettingsOk.Text = "All settings are valid";
            this.lblSettingsOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSettingsOk.Visible = false;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.alertPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGameFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.label1);
            this.Name = "SettingsPage";
            this.Size = new System.Drawing.Size(712, 457);
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.alertPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}
