namespace Eclipse_Mod_Manager
{
    partial class MainPage
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
            this.lblCopyright = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblFirstLaunchTip2 = new System.Windows.Forms.Label();
            this.lblFirstLaunchTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(52, 430);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(608, 18);
            this.lblCopyright.TabIndex = 10;
            this.lblCopyright.Text = "Copyright (C) 2020 - MikkyTzen (https://github.com/wroleader) - MIT License";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monster Hunter World";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(0, 17);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(712, 34);
            this.lblMainTitle.TabIndex = 8;
            this.lblMainTitle.Text = "Eclipse Mod Manager";
            this.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstLaunchTip2
            // 
            this.lblFirstLaunchTip2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstLaunchTip2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFirstLaunchTip2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLaunchTip2.ForeColor = System.Drawing.Color.Navy;
            this.lblFirstLaunchTip2.Location = new System.Drawing.Point(45, 375);
            this.lblFirstLaunchTip2.Name = "lblFirstLaunchTip2";
            this.lblFirstLaunchTip2.Size = new System.Drawing.Size(320, 18);
            this.lblFirstLaunchTip2.TabIndex = 7;
            this.lblFirstLaunchTip2.Text = "(Don\'t wanna see this anymore? Click me!)";
            this.lblFirstLaunchTip2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstLaunchTip
            // 
            this.lblFirstLaunchTip.AutoSize = true;
            this.lblFirstLaunchTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstLaunchTip.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFirstLaunchTip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLaunchTip.ForeColor = System.Drawing.Color.Navy;
            this.lblFirstLaunchTip.Location = new System.Drawing.Point(3, 354);
            this.lblFirstLaunchTip.Name = "lblFirstLaunchTip";
            this.lblFirstLaunchTip.Size = new System.Drawing.Size(362, 21);
            this.lblFirstLaunchTip.TabIndex = 6;
            this.lblFirstLaunchTip.Text = "<--- Configure Eclipse before using it!";
            this.lblFirstLaunchTip.Click += new System.EventHandler(this.lblFirstLaunchTip_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblFirstLaunchTip2);
            this.Controls.Add(this.lblFirstLaunchTip);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(712, 457);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblFirstLaunchTip2;
        private System.Windows.Forms.Label lblFirstLaunchTip;
    }
}
