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
        public FileInModule FileInModule { get; private set; }

        public EditFileInForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            var filepath = string.Empty;
            using (var folderBrowseDialog = new OpenFileDialog())
            {
                if (OpenFileDialog openFileDialog == new OpenFileDialog)
                {
                    filepath = folderBrowseDialog.SelectedPath;

                    var module = new FileInModule(filepath);
                    FileInModule = module;

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
