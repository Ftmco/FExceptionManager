using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ExceptionHandler.Tools
{
    public interface IEmailSender
    {
        Task SendEmailAsync();
    }

    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync() => await Task.Run(() =>
        {
            MailMessage mailMessage = new()
            {
                IsBodyHtml = true,
                From = new("", ""),
                Subject = "",
                Body = ""
            };
            SmtpClient smtpClient = new()
            {
                Port = 25,
                Credentials = new NetworkCredential("", ""),
                EnableSsl = false
            };

            smtpClient.Send(mailMessage);
        });
    }
}
