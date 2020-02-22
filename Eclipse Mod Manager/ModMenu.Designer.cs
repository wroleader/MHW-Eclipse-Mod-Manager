namespace Eclipse_Mod_Manager
{
    partial class ModMenu
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
            this.lblEclModMenu = new System.Windows.Forms.Label();
            this.btnAddNewMod = new System.Windows.Forms.Button();
            this.lblModList = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDisableAll = new System.Windows.Forms.Button();
            this.btnRemMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMListDetect = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstModList = new System.Windows.Forms.ListView();
            this.btnBackup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNoMods = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEclModMenu
            // 
            this.lblEclModMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEclModMenu.ForeColor = System.Drawing.Color.White;
            this.lblEclModMenu.Location = new System.Drawing.Point(0, 17);
            this.lblEclModMenu.Name = "lblEclModMenu";
            this.lblEclModMenu.Size = new System.Drawing.Size(712, 20);
            this.lblEclModMenu.TabIndex = 0;
            this.lblEclModMenu.Text = "Eclipse MM - Monster Hunter World Modlist";
            this.lblEclModMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEclModMenu.Click += new System.EventHandler(this.lblEclModMenu_Click);
            // 
            // btnAddNewMod
            // 
            this.btnAddNewMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddNewMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewMod.FlatAppearance.BorderSize = 0;
            this.btnAddNewMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMod.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMod.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMod.Location = new System.Drawing.Point(273, 410);
            this.btnAddNewMod.Name = "btnAddNewMod";
            this.btnAddNewMod.Size = new System.Drawing.Size(88, 43);
            this.btnAddNewMod.TabIndex = 2;
            this.btnAddNewMod.Text = "Add Mod";
            this.btnAddNewMod.UseVisualStyleBackColor = false;
            this.btnAddNewMod.Click += new System.EventHandler(this.btnAddNewMod_Click);
            // 
            // lblModList
            // 
            this.lblModList.AutoSize = true;
            this.lblModList.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModList.ForeColor = System.Drawing.Color.White;
            this.lblModList.Location = new System.Drawing.Point(17, 45);
            this.lblModList.Name = "lblModList";
            this.lblModList.Size = new System.Drawing.Size(120, 18);
            this.lblModList.TabIndex = 3;
            this.lblModList.Text = "Your mod list:";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(618, 410);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(88, 43);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            // 
            // btnDisableAll
            // 
            this.btnDisableAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDisableAll.FlatAppearance.BorderSize = 0;
            this.btnDisableAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisableAll.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableAll.ForeColor = System.Drawing.Color.White;
            this.btnDisableAll.Location = new System.Drawing.Point(100, 410);
            this.btnDisableAll.Name = "btnDisableAll";
            this.btnDisableAll.Size = new System.Drawing.Size(88, 43);
            this.btnDisableAll.TabIndex = 6;
            this.btnDisableAll.Text = "Disable All";
            this.btnDisableAll.UseVisualStyleBackColor = false;
            // 
            // btnRemMod
            // 
            this.btnRemMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRemMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemMod.Enabled = false;
            this.btnRemMod.FlatAppearance.BorderSize = 0;
            this.btnRemMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemMod.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemMod.ForeColor = System.Drawing.Color.White;
            this.btnRemMod.Location = new System.Drawing.Point(367, 410);
            this.btnRemMod.Name = "btnRemMod";
            this.btnRemMod.Size = new System.Drawing.Size(88, 43);
            this.btnRemMod.TabIndex = 7;
            this.btnRemMod.Text = "Remove Mod";
            this.btnRemMod.UseVisualStyleBackColor = false;
            this.btnRemMod.Click += new System.EventHandler(this.btnRemMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preset:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(377, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Default";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(553, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "New Preset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblMListDetect
            // 
            this.lblMListDetect.AutoSize = true;
            this.lblMListDetect.Location = new System.Drawing.Point(236, 425);
            this.lblMListDetect.Name = "lblMListDetect";
            this.lblMListDetect.Size = new System.Drawing.Size(0, 13);
            this.lblMListDetect.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(632, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 21);
            this.button2.TabIndex = 12;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstModList
            // 
            this.lstModList.BackColor = System.Drawing.Color.DimGray;
            this.lstModList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstModList.CheckBoxes = true;
            this.lstModList.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstModList.ForeColor = System.Drawing.Color.White;
            this.lstModList.HideSelection = false;
            this.lstModList.Location = new System.Drawing.Point(6, 71);
            this.lstModList.Name = "lstModList";
            this.lstModList.Size = new System.Drawing.Size(700, 333);
            this.lstModList.TabIndex = 13;
            this.lstModList.UseCompatibleStateImageBehavior = false;
            this.lstModList.View = System.Windows.Forms.View.List;
            this.lstModList.SelectedIndexChanged += new System.EventHandler(this.lstModList_SelectedIndexChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(461, 410);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(88, 43);
            this.btnBackup.TabIndex = 14;
            this.btnBackup.Text = "Backup Mods";
            this.btnBackup.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Backup Saves";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lblNoMods
            // 
            this.lblNoMods.AutoSize = true;
            this.lblNoMods.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoMods.ForeColor = System.Drawing.Color.White;
            this.lblNoMods.Location = new System.Drawing.Point(96, 214);
            this.lblNoMods.Name = "lblNoMods";
            this.lblNoMods.Size = new System.Drawing.Size(510, 22);
            this.lblNoMods.TabIndex = 16;
            this.lblNoMods.Text = "Your mods will appear here as soon as you add any.";
            this.lblNoMods.Visible = false;
            // 
            // ModMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lblNoMods);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lstModList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblMListDetect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemMod);
            this.Controls.Add(this.btnDisableAll);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblModList);
            this.Controls.Add(this.btnAddNewMod);
            this.Controls.Add(this.lblEclModMenu);
            this.Name = "ModMenu";
            this.Size = new System.Drawing.Size(713, 457);
            this.Load += new System.EventHandler(this.ModMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEclModMenu;
        private System.Windows.Forms.Button btnAddNewMod;
        private System.Windows.Forms.Label lblModList;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDisableAll;
        private System.Windows.Forms.Button btnRemMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMListDetect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lstModList;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNoMods;
    }
}
