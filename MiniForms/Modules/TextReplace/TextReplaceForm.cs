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

namespace MiniForms.Modules.TextReplace
{
    public partial class TextReplaceForm : Form
    {
        // TODO: Add property for TextReplaceModule
        public TextReplaceModule TextReplaceModule { get; set; }
        public TextReplaceForm()
        {
            InitializeComponent();
        }

        private void btnReWrite_Click(object sender, EventArgs e)
        {
            try
            {
                TextReplaceModule = new TextReplaceModule(tbOld.Text, tbNew.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
