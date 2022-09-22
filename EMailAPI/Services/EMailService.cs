using EMailAPI.Dtos;
using EMailAPI.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace EMailAPI.Services
{
    public class EMailService : IEMailService
    {

        public void SendEmail(EMailDto request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(" Mail (From)"));
            email.To.Add(MailboxAddress.Parse(" Mail (To)"));
            email.Subject = "Test EMailSubject";
            email.Body = new TextPart(TextFormat.Plain)
            {
                Text = request.Body.ToString()
            };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp host name ", "int smtp port number", SecureSocketOptions.StartTls);
            smtp.Authenticate("mail", "password");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
