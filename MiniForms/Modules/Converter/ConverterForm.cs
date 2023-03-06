using MiniForms.Modules.MailOut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniForms.Modules.Converter
{
    public partial class ConverterForm : Form
    {
        public ConvertModule ConvertModule { get; set; }
        public ConverterForm()
        {
            InitializeComponent();
        }
       
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text != "")
            {
                ConvertModule = new ConvertModule(tbPassword.Text);
                MessageBox.Show("Encryption succesvol");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Geen geldig password");
            }
           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
