﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eclipse_Mod_Manager.Properties;

namespace Eclipse_Mod_Manager
{
    using mySetts = Eclipse_Mod_Manager.Properties.Settings;
    class ModManager
    {
        public void AddMod(string modFile, string fileName)
        {
            try
            {
                File.Move(modFile, mySetts.Default.ModsFolder + @"\" + fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("There has been an error adding the mod.\n\nError: " + e, "Eclipse Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveMod(string fileName)
        {
            try
            {
                File.Move(mySetts.Default.RemovedFolder + @"\" + fileName, mySetts.Default.RemovedFolder + @"\" + fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was an error removing the mod.\n\nError: " + e,"Eclipse Mod Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ApplyMods(string fileName)
        {
            MessageBox.Show(fileName);
        }

        public void DisableMods(string fileName)
        {
            MessageBox.Show(fileName);
        }
    }
}
