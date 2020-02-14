using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eclipse_Mod_Manager
{
    public partial class ModMenu : UserControl
    {
        ConfigManager ConfMan = new ConfigManager();
        ModManager ModMan = new ModManager();
        private string WorkingFolder;
        public ModMenu()
        {
            InitializeComponent();
        }

        private void lblEclModMenu_Click(object sender, EventArgs e)
        {

        }

        private void ModMenu_Load(object sender, EventArgs e)
        {
            GenerateList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateList();
        }

        private void GenerateList()
        {
            WorkingFolder = ConfMan.ReturnModsFolder();
            lstModList.Items.Clear();

            string[] files = Directory.GetFiles(WorkingFolder);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                ListViewItem listItem = new ListViewItem(fileName);
                listItem.Tag = file;
                lstModList.Items.Add(listItem);
                lstModList.View = View.List;
            }
        }

        private void btnAddNewMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "zip files (*.zip)|*.zip";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Select the zip that contains the mod";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ModMan.AddMod(dialog.FileName, dialog.SafeFileName);
                GenerateList();
            }
        }
    }
}
