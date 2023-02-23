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
        public TextReplaceForm()
        {
            InitializeComponent();
        }

        private void btnReWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string str1 = File.ReadAllText(tbPath.Text);
                string value = str1.Replace(tbOld.Text, tbNew.Text);
                File.WriteAllText(tbPath.Text, value);
                MessageBox.Show("Het document is aangepast");
                this.Close();
            }
            catch(Exception ex)
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
