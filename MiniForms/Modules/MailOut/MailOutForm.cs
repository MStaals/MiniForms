using Microsoft.VisualBasic;
using MiniForms.Modules.Text_to_PDF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniForms.Modules.MailOut
{
    public partial class MailOutForm : Form
    {
        public MailOutModule MailOutModule { get; set; }
        public MailOutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSender.Text == "")
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld");
                    return;
                }
                if (tbSendTo.Text == "")
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld");
                    return;
                }
                if (tbMailtext.Text == "")
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld");
                    return;
                }
                else
                {
                    MailOutModule = new MailOutModule(tbSendTo.Text, tbSender.Text, tbBcc.Text, tbCc.Text, tbMailtext.Text, tbSubject.Text);
                    MessageBox.Show("Mail versturen gelukt");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
               
            }
            catch
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }

            
        }
    }
}
