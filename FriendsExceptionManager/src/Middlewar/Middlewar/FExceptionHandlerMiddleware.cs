using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Fteam.Middlewar
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
                    context.
                    await _next(context);
                }
            });
        }
    }
}
