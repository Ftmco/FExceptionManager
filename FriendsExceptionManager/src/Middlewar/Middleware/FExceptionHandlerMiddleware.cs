using FTeam.Middlewar.StaticVarables;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FTeam.Middlewar
{
    /// <summary>
    /// Exception Handler Middelware
    /// </summary>
    public class FExceptionHandlerMiddleware
    {
        /// <summary>
        /// Http Request Delegate
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Friends Exception Handler Constractor
        /// </summary>
        /// <param name="next"></param>
        public FExceptionHandlerMiddleware(RequestDelegate next) => _next = next;

        /// <summary>
        /// Invoke Middleware
        /// </summary>
        /// <param name="context">HttpContext</param>
        /// <returns></returns>
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
                    context.Response.Redirect(StaticVariables.ErrorHandeligPath??"/500err");
                    await _next(context);
                }
            });
        }
    }
}
