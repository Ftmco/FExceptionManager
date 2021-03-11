using Microsoft.AspNetCore.Builder;
using System;

namespace Fteam.Middlewar
{
    public static class FExceptionHandler
    {
        /// <summary>
        /// Using Friends Asp.net core Exception Handler Midddleware
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <returns>a reference to this instance after opration is compelete</returns>
        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }

        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app,Action<> action)
        {

        }
    }
}
