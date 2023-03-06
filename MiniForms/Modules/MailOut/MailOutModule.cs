using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.MailOut
{
    public class MailOutModule
    {
        private string sendTo { get; set; }
        private string sender { get; set; }
        private string bcc { get; set; }
        private string cc { get; set; }
        private string mailText { get; set; }
        private string subject { get; set; }

        public MailOutModule(string SendTo, string sender, string bcc, string cc, string mailText, string subject)
        {
            this.sendTo = SendTo;
            this.sender = sender;
            this.bcc = bcc;
            this.cc = cc;
            this.mailText = mailText;
            this.subject = subject;
        }
        public bool Execute()
        {

            MailAddress to = new MailAddress(sendTo);
            MailAddress from = new MailAddress(sender);

            MailMessage email = new MailMessage(from, to);

            if( ! string.IsNullOrEmpty(bcc))
            {
                email.Bcc.Add(bcc);
            }
            if (!string.IsNullOrEmpty(cc))
            {
                email.CC.Add(cc);
            }
           
            email.Body = mailText;
            email.Subject = subject;





            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-relay.sendinblue.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("max.staals@gmail.com", "pI0XbDS4MAwKjaQh");
            // smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(email);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

    }      
        
}

