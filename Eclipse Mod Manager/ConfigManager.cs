using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using Eclipse_Mod_Manager.Properties;

namespace Eclipse_Mod_Manager
{
    class ConfigManager
    {
        private string WorkingFolder = Environment.CurrentDirectory + @"\Mods";
        public void InitSettings()
        {
            if (!Directory.Exists(WorkingFolder))
            {
                Directory.CreateDirectory(WorkingFolder);
            }

            Settings.Default.FirstLaunch = false;
            SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Default.Save();
        }
        public string ReturnModsFolder()
        {
            return WorkingFolder;
        }
        
        public string ReturnVersion()
        {
            return "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
        }
        public void AcceptLicense()
        {
            Settings.Default.LicenseAccepted = true;
            SaveSettings();
        }
        public bool CheckLicense()
        {
            return Settings.Default.LicenseAccepted;
        }

        public void SaveGameFolder(string GFolder)
        {
            Settings.Default.GameFolder = GFolder;
            SaveSettings();
        }

        public void DisableTipLabels()
        {
            Settings.Default.TipLabelsHidden = true;
            SaveSettings();
        }
    }
}
