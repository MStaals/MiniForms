using MiniForms.Modules.FileIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniForms.Modules.FileOut
{
    public partial class EditFileOutForm : Form
    {
        public EditFileOutForm()
        {
            InitializeComponent();
        }

        private string generateProjectFolder()
        {
            // Setup desination folder

            string directory = "C:\\Temp";

            
            return directory;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var projectDirectory = generateProjectFolder();

            var filepath = string.Empty;
            using (var folderBrowseDialog = new FolderBrowserDialog())
            {
                if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = folderBrowseDialog.SelectedPath;
                }
            }

            var module = new FileOutModule(filepath, projectDirectory);


            bool result = module.Execute();

            if (result == false)
            {
                MessageBox.Show("Uitvoeren niet gelukt!");
            }
            this.Close();
        }
    }
}
