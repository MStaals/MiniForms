using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniForms.Modules.FileIn
{
    public partial class EditFileInForm : Form
    {
        public EditFileInForm(FileInModule fileIn)
        {
            InitializeComponent();
        }

        
        private string generateProjectFolder()
        {
            // Setup desination folder
            var projectDirectory = Environment.CurrentDirectory;

            var folderName = Guid.NewGuid().ToString();
            string directory = projectDirectory + "\\Process\\" + folderName;

            // Create project folder/directory
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            return directory;
        }
        public void btnExecute_Click(object sender, EventArgs e)
        {
            
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var projectDirectory = generateProjectFolder();

            var filepath = string.Empty;
            using (var folderBrowseDialog = new FolderBrowserDialog())
            {
                if (folderBrowseDialog.ShowDialog(this) == DialogResult.OK)
                {
                    filepath = folderBrowseDialog.SelectedPath;
                }
            }

            var module = new FileInModule(filepath, projectDirectory);


            bool result = module.Execute();

            if (result == false)
            {
                MessageBox.Show("Uitvoeren niet gelukt!");
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
