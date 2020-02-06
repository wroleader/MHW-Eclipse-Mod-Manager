using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace Eclipse_Mod_Manager
{
    public partial class Form1 : Form
    {
        public const int WN_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
            ConfigManager confMan = new ConfigManager();
            confMan.InitSettings();

            lblVersion.Text = confMan.ReturnVersion();
            btnHome.ForeColor = Color.Black;
            btnHome.BackColor = Color.DimGray;

            if (!confMan.CheckLicense() == true)
            {
                LicenseForm license = new LicenseForm();
                license.Show();
            }
        }

        private void btnModList_Click(object sender, EventArgs e)
        {
            ModMenu subModMenu = new ModMenu();
            frmMainPanel.Controls.Clear();
            frmMainPanel.Controls.Add(subModMenu);
            subModMenu.Show();

            btnHome.ForeColor = Color.Gray;
            btnHome.BackColor = Color.FromArgb(40, 40, 40);

            btnModList.ForeColor = Color.Black;
            btnModList.BackColor = Color.DimGray;

            btnSettings.ForeColor = Color.Gray;
            btnSettings.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainPanel.Controls.Clear();
            btnHome.ForeColor = Color.Black;
            btnHome.BackColor = Color.DimGray;

            btnModList.ForeColor = Color.Gray;
            btnModList.BackColor = Color.FromArgb(40, 40, 40);

            btnSettings.ForeColor = Color.Gray;
            btnSettings.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void navbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.Black;
            btnSettings.BackColor = Color.DimGray;

            btnHome.ForeColor = Color.Gray;
            btnHome.BackColor = Color.FromArgb(40, 40, 40);

            btnModList.ForeColor = Color.Gray;
            btnModList.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
