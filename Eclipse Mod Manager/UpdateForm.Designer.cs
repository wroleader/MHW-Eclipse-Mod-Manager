namespace Eclipse_Mod_Manager
{
    partial class UpdateForm
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
            this.pnlTitlebar = new System.Windows.Forms.Panel();
            this.lblTitlebar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlUpdateImage = new System.Windows.Forms.Panel();
            this.lblUpdChck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewVer = new System.Windows.Forms.Label();
            this.pnlTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitlebar
            // 
            this.pnlTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlTitlebar.Controls.Add(this.lblTitlebar);
            this.pnlTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitlebar.Name = "pnlTitlebar";
            this.pnlTitlebar.Size = new System.Drawing.Size(570, 23);
            this.pnlTitlebar.TabIndex = 0;
            this.pnlTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitlebar_MouseMove);
            // 
            // lblTitlebar
            // 
            this.lblTitlebar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlebar.ForeColor = System.Drawing.Color.White;
            this.lblTitlebar.Location = new System.Drawing.Point(0, 0);
            this.lblTitlebar.Name = "lblTitlebar";
            this.lblTitlebar.Size = new System.Drawing.Size(570, 23);
            this.lblTitlebar.TabIndex = 0;
            this.lblTitlebar.Text = "Eclipse Updater";
            this.lblTitlebar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitlebar_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(474, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Update now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(348, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update later";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlUpdateImage
            // 
            this.pnlUpdateImage.BackgroundImage = global::Eclipse_Mod_Manager.Properties.Resources.exchange;
            this.pnlUpdateImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUpdateImage.Location = new System.Drawing.Point(12, 29);
            this.pnlUpdateImage.Name = "pnlUpdateImage";
            this.pnlUpdateImage.Size = new System.Drawing.Size(57, 42);
            this.pnlUpdateImage.TabIndex = 3;
            // 
            // lblUpdChck
            // 
            this.lblUpdChck.AutoSize = true;
            this.lblUpdChck.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdChck.ForeColor = System.Drawing.Color.White;
            this.lblUpdChck.Location = new System.Drawing.Point(75, 29);
            this.lblUpdChck.Name = "lblUpdChck";
            this.lblUpdChck.Size = new System.Drawing.Size(231, 14);
            this.lblUpdChck.TabIndex = 4;
            this.lblUpdChck.Text = "Eclipse is checking for updates.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your current version is: 1.0.0.0";
            // 
            // lblNewVer
            // 
            this.lblNewVer.AutoSize = true;
            this.lblNewVer.ForeColor = System.Drawing.Color.White;
            this.lblNewVer.Location = new System.Drawing.Point(75, 58);
            this.lblNewVer.Name = "lblNewVer";
            this.lblNewVer.Size = new System.Drawing.Size(0, 13);
            this.lblNewVer.TabIndex = 6;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(570, 149);
            this.Controls.Add(this.lblNewVer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUpdChck);
            this.Controls.Add(this.pnlUpdateImage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTitlebar);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.pnlTitlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitlebar;
        private System.Windows.Forms.Label lblTitlebar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlUpdateImage;
        private System.Windows.Forms.Label lblUpdChck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewVer;
    }
}