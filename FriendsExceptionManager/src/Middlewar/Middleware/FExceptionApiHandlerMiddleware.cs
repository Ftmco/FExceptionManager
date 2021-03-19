using FTeam.Middlewar.Models;
using FTeam.Middlewar.Services;
using FTeam.Middlewar.StaticVarables;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace FTeam.Middlewar
{
    public class FExceptionApiHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly IExceptionHanlder _exceptionHanlder;

        public FExceptionApiHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Run Invoke
            await Task.Run(async () =>
            {
                //Try To Run Application
                try
                {
                    //Run Application
                    await _next(context);
                }
                catch (Exception ex)
                {
                    //Handel Exception and Redirect To Error Page
                    context.Response.Redirect(StaticVariablesApi.ErrorHandeligPathApi ?? "/ExHandler/500Err");
                    FTSnedEmailModel sendEmail = new()
                    {

                    };

                    FTServerEmailOptions serverEmailOptions = new()
                    {

                    };

                    await _exceptionHanlder.ExceptionOccreuudAsync(new EmailModel
                    {
                        SendEmail = sendEmail,
                        EmailServerOptions = serverEmailOptions
                    });
                    await _next(context);
                }
            });
        }
    }
}
