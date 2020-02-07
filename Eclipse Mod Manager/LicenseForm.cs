using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eclipse_Mod_Manager.Properties;

namespace Eclipse_Mod_Manager
{
    public partial class LicenseForm : Form
    {
        public const int WN_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public LicenseForm()
        {
            InitializeComponent();
        }

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WN_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WN_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ConfigManager confMan = new ConfigManager();
            confMan.AcceptLicense();
            MessageBox.Show("Thank you for accepting the license and welcome to Eclipse!\n\nBefore you continue, please remember to configure this application in the Settings page.", "Welcome to Eclipse!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.LicenseAccepted == true)
            {
                btnCloseLicense.Visible = true;
                btnAccept.Visible = false;
                btnRefuse.Visible = false;
                lblAgreement.Text = "Eclipse Mod Manager";
            }
            else
            {
                lblLicAccepted.Visible = false;
            }
        }

        private void btnCloseLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
