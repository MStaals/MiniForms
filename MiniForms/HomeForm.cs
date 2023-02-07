using MiniForms.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void lbModules_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var projectDirectory = generateProjectFolder();
            var module = new FileInModule("C:\\Temp", projectDirectory);
            bool result = module.Execute();

            if(result == false)
            {
                MessageBox.Show("Uitvoeren niet gelukt!");
            }
            
            
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
    }
}
