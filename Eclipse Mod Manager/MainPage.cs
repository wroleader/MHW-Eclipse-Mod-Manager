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

namespace Eclipse_Mod_Manager
{
    public partial class MainPage : UserControl
    {
        readonly ConfigManager confMan = new ConfigManager();
        public MainPage()
        {
            InitializeComponent();
        }

        private void lblFirstLaunchTip_Click(object sender, EventArgs e)
        {
            HideTipLabels();
            confMan.DisableTipLabels(true);
        }
        private void lblFirstLaunchTip2_Click(object sender, EventArgs e)
        {
            HideTipLabels();
            confMan.DisableTipLabels(true);
        }

        private void HideTipLabels()
        {
            lblFirstLaunchTip.Visible = false;
            lblFirstLaunchTip.Enabled = false;
            lblFirstLaunchTip2.Visible = false;
            lblFirstLaunchTip2.Visible = false;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            if (Settings.Default.TipLabelsHidden)
            {
                HideTipLabels();
            }
        }
    }
}
