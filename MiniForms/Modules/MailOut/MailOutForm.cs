using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniForms.Modules.MailOut
{
    public partial class MailOutForm : Form
    {
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
                MailAddress to = new MailAddress(tbSendTo.Text);
                MailAddress from = new MailAddress(tbSender.Text);

                MailMessage email = new MailMessage(from, to);
                
               

                if (tbBcc.Text != "")
                {
                    email.Bcc.Add(tbBcc.Text);
                }
                if (tbCc.Text != "")
                {
                    email.CC.Add(tbCc.Text);
                }

                if(tbMailtext.Text != "")
                {
                    email.Body = tbMailtext.Text;
                }
                else
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld");
                    return;
                }

                if(tbSubject.Text != "")
                {
                    email.Subject = tbSubject.Text;
                    
                }
                else
                {
                    MessageBox.Show("Niet alle velden zijn ingevuld");
                    return;
                }


                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp-relay.sendinblue.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("max.staals@gmail.com", "pI0XbDS4MAwKjaQh");
                // smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;

                try
                {
                    smtp.Send(email);
                    this.Close();
                }
                catch (SmtpException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
        }
    }
}
