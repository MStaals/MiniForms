using MiniForms.Modules.Converter;
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
using static MiniForms.Modules.Converter.ConverterForm;

namespace MiniForms.Modules.Decrypt
{
    public partial class DecryptForm : Form
    {
        public DecryptModule DecryptModule { get; set; }
        public DecryptForm()
        {
            InitializeComponent();
        }
        
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != "")
            {
                DecryptModule = new DecryptModule(tbPassword.Text);
                MessageBox.Show("Decryption key succesvol ingesteld");
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
