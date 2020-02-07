namespace Eclipse_Mod_Manager
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.titleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTheLicense = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnRefuse = new System.Windows.Forms.Button();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.btnCloseLicense = new System.Windows.Forms.Button();
            this.lblLicAccepted = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.titleBar.Controls.Add(this.lblTitle);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(703, 26);
            this.titleBar.TabIndex = 0;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBar_Paint);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(703, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Eclipse Mod Manager License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            // 
            // lblTheLicense
            // 
            this.lblTheLicense.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLicense.ForeColor = System.Drawing.Color.Gray;
            this.lblTheLicense.Location = new System.Drawing.Point(12, 61);
            this.lblTheLicense.Name = "lblTheLicense";
            this.lblTheLicense.Size = new System.Drawing.Size(679, 330);
            this.lblTheLicense.TabIndex = 1;
            this.lblTheLicense.Text = resources.GetString("lblTheLicense.Text");
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.Gray;
            this.btnAccept.Location = new System.Drawing.Point(565, 394);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(126, 32);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnRefuse
            // 
            this.btnRefuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRefuse.FlatAppearance.BorderSize = 0;
            this.btnRefuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuse.ForeColor = System.Drawing.Color.Gray;
            this.btnRefuse.Location = new System.Drawing.Point(433, 394);
            this.btnRefuse.Name = "btnRefuse";
            this.btnRefuse.Size = new System.Drawing.Size(126, 32);
            this.btnRefuse.TabIndex = 3;
            this.btnRefuse.Text = "Refuse";
            this.btnRefuse.UseVisualStyleBackColor = false;
            this.btnRefuse.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAgreement
            // 
            this.lblAgreement.ForeColor = System.Drawing.Color.Maroon;
            this.lblAgreement.Location = new System.Drawing.Point(0, 29);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(703, 21);
            this.lblAgreement.TabIndex = 4;
            this.lblAgreement.Text = "You must agree to this license in order to use this software:";
            this.lblAgreement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCloseLicense
            // 
            this.btnCloseLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCloseLicense.FlatAppearance.BorderSize = 0;
            this.btnCloseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLicense.ForeColor = System.Drawing.Color.Gray;
            this.btnCloseLicense.Location = new System.Drawing.Point(565, 394);
            this.btnCloseLicense.Name = "btnCloseLicense";
            this.btnCloseLicense.Size = new System.Drawing.Size(126, 32);
            this.btnCloseLicense.TabIndex = 5;
            this.btnCloseLicense.Text = "Close";
            this.btnCloseLicense.UseVisualStyleBackColor = false;
            this.btnCloseLicense.Click += new System.EventHandler(this.btnCloseLicense_Click);
            // 
            // lblLicAccepted
            // 
            this.lblLicAccepted.AutoSize = true;
            this.lblLicAccepted.ForeColor = System.Drawing.Color.Green;
            this.lblLicAccepted.Location = new System.Drawing.Point(118, 401);
            this.lblLicAccepted.Name = "lblLicAccepted";
            this.lblLicAccepted.Size = new System.Drawing.Size(441, 19);
            this.lblLicAccepted.TabIndex = 6;
            this.lblLicAccepted.Text = "You have already accepted the license agreement.";
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(703, 438);
            this.Controls.Add(this.lblLicAccepted);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.btnRefuse);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblTheLicense);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.btnCloseLicense);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LicenseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LicenseForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LicenseForm_Load);
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTheLicense;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnRefuse;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Button btnCloseLicense;
        private System.Windows.Forms.Label lblLicAccepted;
    }
}