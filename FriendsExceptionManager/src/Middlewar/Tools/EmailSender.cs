using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middlewar.Tools
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
        Task SendEmailAsync(EmailViewModel email);
    }

    /// <summary>
    /// Email Sender Service Impelement IEmailSender 
    /// </summary>
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(EmailViewModel email) => await Task.Run(() =>
        {
            MailMessage mailMessage = new()
            {
                IsBodyHtml = email.IsBodyHtml,
                From = new(email.From, email.DisplayName),
                Subject = email.Subject,
                Body = email.Body
            };

            mailMessage.To.Add(email.To);

            SmtpClient smtpClient = new()
            {
                Port = email.Port,
                Credentials = new NetworkCredential(email.UserName, email.Password),
                EnableSsl = email.EnableSSL
            };

            smtpClient.Send(mailMessage);
        });
    }
}
