using FTeam.Middlewar.StaticVarables;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middlewar.Middleware
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
            await Task.Run(async () =>
            {
                try
                {
                    await _next(context);
                }
                catch
                {
                    context.Response.Redirect(StaticVariablesApi.ErrorHandeligPathApi ?? "/ExHandler/500Err");
                    await _next(context);
                }
            });
        }
    }
}
