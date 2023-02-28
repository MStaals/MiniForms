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
        // Property toevoegen voor FileOutModule.
        public FileOutModule FileOutModule { get; private set; }
        public EditFileOutForm()
        {
            InitializeComponent();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {

            var filepath = string.Empty;
            using (var folderBrowseDialog = new FolderBrowserDialog())
            {
                if (folderBrowseDialog.ShowDialog(this) == DialogResult.OK)
                {
                    
                    filepath = folderBrowseDialog.SelectedPath;

                    var module = new FileOutModule(filepath);
                    FileOutModule = module;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
