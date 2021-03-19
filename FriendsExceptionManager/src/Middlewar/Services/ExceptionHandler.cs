using FTeam.Middlewar.Models;
using FTeam.Middlewar.Tools;
using System;
using System.Threading.Tasks;

namespace FTeam.Middlewar.Services
{
    public class ExceptionHandler : IExceptionHanlder
    {
        private readonly IEmailSender _emailTool;

        public ExceptionHandler(IEmailSender emailTool)
        {
            _emailTool = emailTool;
        }

        public async Task ExceptionOccreuudAsync(EmailModel emailModel)
        {
            await Task.Run(async () =>
                await _emailTool.SendEmailAsync(emailModel));
        }
    }
}
