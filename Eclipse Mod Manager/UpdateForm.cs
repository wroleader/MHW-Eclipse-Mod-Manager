using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace Eclipse_Mod_Manager
{
    public partial class UpdateForm : Form
    {
        // Set up variables for Titlebar panel drag.
        public const int WN_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            lblUpdChck.Text = "Eclipse Mod Manager is now checking for updates. Please wait.";
            checkForUpdates();
        }
        private void checkForUpdates()
        {
            AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            AutoUpdater.OpenDownloadPage = true;
            AutoUpdater.Start("https://mikki.derg.nz/downloads/eclipseupdate.xml");
        }
        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    lblUpdChck.Text = "There is a new version of Eclipse Mod Manager available.";
                    lblNewVer.Text = "Do you want to download it?";
                    button1.Text = "Update now";
                }
                else
                {
                    lblUpdChck.Text = "Eclipse is up to date.";
                    button1.Text = "Close";
                    button2.Visible = false;
                }
            }
            else
            {
                lblUpdChck.Text = "Could not connect to update server.";
                lblNewVer.Text = "Please check your internet connection or firewall settings.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Update now")
            {
                try
                {
                    Process gProcess = new Process();
                    gProcess.StartInfo.FileName = "https://github.com/wroleader/MHW-Eclipse-Mod-Manager/releases";
                    gProcess.Start();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Eclipse cannot find the default web browser.\n\nTry manually visiting https://github.com/wroleader/MHW-Eclipse-Mod-Manager. \n\nError: " + exception, "Eclipse Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (button1.Text == "Close")
            {
                this.Close();
            }
        }

        private void pnlTitlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WN_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTitlebar_MouseMove(object sender, MouseEventArgs e)
        {
            pnlTitlebar_MouseMove(sender, e);
        }
    }
}
