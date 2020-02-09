using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
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
            Settings.Default.ModsFolder = WorkingFolder;
            Settings.Default.FirstLaunch = false;
            Save();
        }
        private void Save()
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
            Save();
        }
        public bool CheckLicense()
        {
            return Settings.Default.LicenseAccepted;
        }
        public void SaveGameFolder(string GFolder)
        {
            Settings.Default.GameFolder = GFolder;
            Settings.Default.nativePCFolder = GFolder + @"\nativePC";
            Save();
        }
        public void DisableTipLabels(bool setting)
        {
            if (setting)
            {
                Settings.Default.TipLabelsHidden = true;
                Save();
            }
            else
            {
                Settings.Default.TipLabelsHidden = false;
                Save();
            }
        }

        public bool GameFolderCorrect(string path)
        {
            if (File.Exists(path + @"\MonsterHunterWorld.exe"))
            {
                return true;
            }
            return false;
        }
        public bool AreTipsDisabled()
        {
            if (Settings.Default.TipLabelsHidden)
            {
                return true;
            }
            return false;
        }

        public bool StrackersLoaderInstalled()
        {
            if (!File.Exists(Settings.Default.GameFolder + @"\dinput8.dll"))
            {
                return false;
            }
            return true;
        }
    }
}
