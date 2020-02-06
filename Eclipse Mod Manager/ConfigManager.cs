using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Eclipse_Mod_Manager
{
    class ConfigManager
    {
        public void InitSettings()
        {
            
        }
        
        public string ReturnVersion()
        {
            string version = "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
            return version;
        }
        public void AcceptLicense()
        {
            Properties.Settings.Default.LicenseAccepted = true;
            Properties.Settings.Default.Save();
        }
        public bool CheckLicense()
        {
            return Properties.Settings.Default.LicenseAccepted;
        }
    }
}
