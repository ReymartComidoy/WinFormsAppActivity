using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace WinFormsAppActivity
{
    public interface IEmailService
    {
        void SendInvoice(string recipientEmail, decimal total);
    }

    public interface IPrinterService
    {
        void PrintInvoice(string recipientEmail, decimal total);
    }

    public class SmtpEmailService : IEmailService
    {
        private readonly string _smtpHost;

        public SmtpEmailService(string smtpHost = "smtp.gmail.com")
        {
            _smtpHost = smtpHost;
        }

        public void SendInvoice(string recipientEmail, decimal total)
        {
            using (var smtp = new SmtpClient(_smtpHost))
            {
                var mail = new MailMessage("store@shop.com", recipientEmail)
                {
                    Body = $"Your total is {total:C}"
                };
                smtp.Send(mail);
            }
        }
    }
}
