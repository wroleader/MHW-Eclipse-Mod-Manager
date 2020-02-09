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
using System.IO;
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
            }
            if (!confMan.GameFolderCorrect(foldBrowse.SelectedPath))
            {
                MessageBox.Show("Eclipse cannot find MonsterHunterWorld.exe\n\nPlease try again.", "Eclipse Mod Manager", MessageBoxButtons.OK);
            }
            else
            {
                if (!confMan.StrackersLoaderInstalled())
                {
                    DialogResult dResult = MessageBox.Show("Stracker's Loader is not installed, so some mods might not work.\n\nWould you like a link to download it?", "Eclipse Mod Manager", MessageBoxButtons.YesNo);
                    if (dResult == DialogResult.Yes)
                    {
                        lblStrckNotInstalled.Visible = true;
                        Process gProcess = new Process();
                        gProcess.StartInfo.FileName = "https://www.nexusmods.com/monsterhunterworld/mods/1982";
                        gProcess.Start();
                        gProcess.Close();
                    }
                }
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
            if (confMan.AreTipsDisabled())
            {
                chkTips.Checked = false;
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            gtProcess.StartInfo.FileName = "https://github.com/wroleader/MHW-Eclipse-Mod-Manager";
            gtProcess.Start();
            gtProcess.Close();
        }

        private void lblAlerts_Click(object sender, EventArgs e)
        {

        }

        private void chkTips_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            confMan.SaveGameFolder(foldBrowse.SelectedPath);
            MessageBox.Show("Settings saved successfully.", "Eclipse Mod Manager");
        }
    }
}
