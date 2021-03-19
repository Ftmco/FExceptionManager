using FTeam.Middlewar.StaticVarables;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FTeam.Middlewar
{
    public class FExceptionApiHandlerMiddleware
    {
        private readonly RequestDelegate _next;

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
                catch
                {
                    //Handel Exception and Redirect To Error Page
                    context.Response.Redirect(StaticVariablesApi.ErrorHandeligPathApi ?? "/ExHandler/500Err");
                    await _next(context);
                }
            });
        }
    }
}
