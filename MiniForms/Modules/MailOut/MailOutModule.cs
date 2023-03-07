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
        private string _sendTo { get; set; }
        private string _sender { get; set; }
        private string _bcc { get; set; }
        private string _cc { get; set; }
        private string _mailText { get; set; }
        private string _subject { get; set; }

        public MailOutModule(string SendTo, string Sender, string Bcc, string Cc, string MailText, string Subject)
        {
            this._sendTo = SendTo;
            this._sender = Sender;
            this._bcc = Bcc;
            this._cc = Cc;
            this._mailText = MailText;
            this._subject = Subject;
        }
        public bool Execute()
        {

            MailAddress to = new MailAddress(_sendTo);
            MailAddress from = new MailAddress(_sender);

            MailMessage email = new MailMessage(from, to);

            if( ! string.IsNullOrEmpty(_bcc))
            {
                email.Bcc.Add(_bcc);
            }
            if (!string.IsNullOrEmpty(_cc))
            {
                email.CC.Add(_cc);
            }
           
            email.Body = _mailText;
            email.Subject = _subject;

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

