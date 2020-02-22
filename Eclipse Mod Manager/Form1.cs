using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;
using Eclipse_Mod_Manager.Properties;
using System.Diagnostics;
using AutoUpdaterDotNET;

namespace Eclipse_Mod_Manager
{
    public partial class Form1 : Form
    {
        // Set up variables for Titlebar panel drag.
        public const int WN_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        readonly ConfigManager confMan = new ConfigManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WN_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            confMan.InitSettings();
            if (!confMan.CheckLicense())
            {
                LicenseForm license = new LicenseForm();
                license.ShowDialog(this);
            }
            MainPage subMainPage = new MainPage();
            
            frmMainPanel.Controls.Clear();
            frmMainPanel.Controls.Add(subMainPage);

            lblVersion.Text = confMan.ReturnVersion();
            btnHome.ForeColor = Color.White;
            btnHome.BackColor = Color.DimGray;
        }

        private void btnModList_Click(object sender, EventArgs e)
        {
            ModMenu subModMenu = new ModMenu();
            frmMainPanel.Controls.Clear();
            frmMainPanel.Controls.Add(subModMenu);
            subModMenu.Show();

            btnHome.ForeColor = Color.White;
            btnHome.BackColor = Color.FromArgb(40, 40, 40);

            btnModList.ForeColor = Color.White;
            btnModList.BackColor = Color.DimGray;

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainPage subMainPage = new MainPage();
            frmMainPanel.Controls.Clear();
            frmMainPanel.Controls.Add(subMainPage);

            btnHome.ForeColor = Color.White;
            btnHome.BackColor = Color.DimGray;

            btnModList.ForeColor = Color.White;
            btnModList.BackColor = Color.FromArgb(40, 40, 40);

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you want to close Eclipse?", "Eclipse Mod Manager", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsPage subSettingsPage = new SettingsPage();
            frmMainPanel.Controls.Clear();
            frmMainPanel.Controls.Add(subSettingsPage);
            subSettingsPage.Show();

            btnSettings.ForeColor = Color.White;
            btnSettings.BackColor = Color.DimGray;

            btnHome.ForeColor = Color.White;
            btnHome.BackColor = Color.FromArgb(40, 40, 40);

            btnModList.ForeColor = Color.White;
            btnModList.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process gProcess = new Process();
            gProcess.StartInfo.FileName = "https://github.com/wroleader";
            gProcess.Start();
            gProcess.Close();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            Process gProcess = new Process();
            gProcess.StartInfo.FileName = "https://ko-fi.com/mikkytzen";
            gProcess.Start();
            gProcess.Close();
        }
        
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            titleBar_MouseMove(sender, e);
        }

        private void navbarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            titleBar_MouseMove(sender, e);
        }
    }
}
