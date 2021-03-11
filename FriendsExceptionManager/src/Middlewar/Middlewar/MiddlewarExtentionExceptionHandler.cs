using Fteam.Middlewar.Models;
using Microsoft.AspNetCore.Builder;
using System;

//Friends Team Co Develop this Pakacge 
//You Can See Other Packages  In https://Github.com/ftmco
//Friends Team #Love_Open_Source 

namespace Fteam.Middlewar
{
    /// <summary>
    /// Friends Team Co Exception Handler Middelware
    /// </summary>
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


        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, string errorHandelingPath)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (errorHandelingPath == null)
            {
                throw new ArgumentNullException(nameof(errorHandelingPath));
            }

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }

        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, FTServerEmailOptions emailOptions)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (emailOptions == null)
            {
                throw new ArgumentNullException(nameof(emailOptions));
            }

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }

        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, FTExceptionHandlerOptions exceptionHandlerOptions)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (exceptionHandlerOptions == null)
            {
                throw new ArgumentNullException(nameof(exceptionHandlerOptions));
            }

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }
    }
}
