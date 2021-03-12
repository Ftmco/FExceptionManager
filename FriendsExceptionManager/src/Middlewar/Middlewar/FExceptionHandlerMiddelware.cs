using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Fteam.Middlewar
{
    /// <summary>
    /// Exception Handler Middelware
    /// </summary>
    public class FExceptionHandlerMiddelware
    {
        /// <summary>
        /// Http Request Delegate
        /// </summary>
        private readonly RequestDelegate _next;

        public FExceptionHandlerMiddelware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            await Task.Run(async () =>
            {
                try
                {
                    await _next(context);
                }
                catch
                {
                    await _next(context);
                }
            });
        }
    }
}
