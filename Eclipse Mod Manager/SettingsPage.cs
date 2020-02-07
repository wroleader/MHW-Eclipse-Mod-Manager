using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eclipse_Mod_Manager.Properties;
using System.Diagnostics;

namespace Eclipse_Mod_Manager
{
    public partial class SettingsPage : UserControl
    {
        private ConfigManager confMan = new ConfigManager();
        private Process gtProcess = new Process();
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LicenseForm license = new LicenseForm();
            license.Show();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (foldBrowse.ShowDialog() == DialogResult.OK)
            {
                txtGameFolder.Text = foldBrowse.SelectedPath;
                confMan.SaveGameFolder(foldBrowse.SelectedPath);
                MessageBox.Show("The settings have been saved.", "");
            }
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Settings.Default.GameFolder) || Settings.Default.GameFolder == "none" || txtGameFolder.Text == "Select your game's folder")
            {
                txtGameFolder.Text = Settings.Default.GameFolder;
                lblGFNotSet.Visible = false;
                lblSettingsOk.Visible = true;
                lblUnresIssues.Text = "No issues found";
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            gtProcess.StartInfo.FileName = "https://github.com/wroleader/MHW-Eclipse-Mod-Manager";
            gtProcess.Start();
            gtProcess.Close();
        }
    }
}
