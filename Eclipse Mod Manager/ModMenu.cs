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
        readonly ConfigManager ConfMan = new ConfigManager();
        readonly ModManager ModMan = new ModManager();
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
            emptyCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateList();
            emptyCheck();
        }

        private void GenerateList()
        {
            WorkingFolder = ConfMan.ReturnModsFolder();
            lstModList.Items.Clear();

            string[] files = Directory.GetFiles(WorkingFolder);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                ListViewItem listItem = new ListViewItem(fileName)
                {
                    Tag = file
                };
                lstModList.Items.Add(listItem);
                lstModList.View = View.List;
            }
        }

        private void btnAddNewMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "zip files (*.zip)|*.zip",
                InitialDirectory = "C:\\",
                Title = "Select the zip that contains the mod"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ModMan.AddMod(dialog.FileName, dialog.SafeFileName);
                GenerateList();
            }
        }

        private void btnRemMod_Click(object sender, EventArgs e)
        {
            if (lstModList.SelectedItems.Count > 0)
            {

            }
            GenerateList();
            emptyCheck();
            btnRemMod.Enabled = false;
        }

        private void emptyCheck()
        {
            if (lstModList.Items.Count == 0)
            {
                lblNoMods.Visible = true;
            }
        }

        private void lstModList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModList.SelectedItems.Count > 0)
            {
                btnRemMod.Enabled = true;
            }
        }
    }
}
