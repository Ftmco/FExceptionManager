using FTeam.Middlewar.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FTeam.Middlewar.Tools
{
    /// <summary>
    /// Email Sender Service
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Send Email Async
        /// </summary>
        /// <param name="email">Email Info</param>
        Task SendEmailAsync(EmailModel email);
    }

    /// <summary>
    /// Email Sender Service Impelement IEmailSender 
    /// </summary>
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(EmailModel email) => await Task.Run(() =>
        {
            MailMessage mailMessage = new()
            {
                IsBodyHtml = email.SendEmail.IsBodyHtml,
                From = new(email.SendEmail.From, email.EmailServerOptions.DisplayName),
                Subject = email.SendEmail.Subject,
                Body = email.SendEmail.Body
            };

            mailMessage.To.Add(email.SendEmail.To);

            SmtpClient smtpClient = new()
            {
                Port = email.EmailServerOptions.Port,
                Credentials = new NetworkCredential(email.EmailServerOptions.UserName, email.EmailServerOptions.Password),
                EnableSsl = email.EmailServerOptions.EnableSSL
            };

            smtpClient.Send(mailMessage);
        });
    }
}
