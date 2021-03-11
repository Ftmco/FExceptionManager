using Fteam.Middlewar.Models;
using Fteam.Middlewar.StaticVarables;
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

        /// <summary>
        ///  Using Friends Asp.net core Exception Handler Midddleware
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="errorHandelingPath">Error Handeling Path To Redirect Application </param>
        /// <returns>a reference to this instance after opration is compelete</returns>
        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, string errorHandelingPath)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            StaticVariables.ErrorHandeligPath = errorHandelingPath ??
                throw new ArgumentNullException(nameof(errorHandelingPath));

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }

        /// <summary>
        /// Using Friends Asp.net core Exception Handler Midddleware
        /// </summary>
        /// <param name="app"></param>
        /// <param name="emailOptions"></param>
        /// <returns>a reference to this instance after opration is compelete</returns>
        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, FTServerEmailOptions emailOptions)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            StaticVariables.FTServerEmailOptions = emailOptions ??
                throw new ArgumentNullException(nameof(emailOptions));

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }

        /// <summary>
        /// Using Friends Asp.net core Exception Handler Midddleware
        /// </summary>
        /// <param name="app"></param>
        /// <param name="exceptionHandlerOptions"></param>
        /// <returns>a reference to this instance after opration is compelete</returns>
        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, FTExceptionHandlerOptions exceptionHandlerOptions)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            StaticVariables.FTExceptionHandlerOptions = exceptionHandlerOptions ??
                throw new ArgumentNullException(nameof(exceptionHandlerOptions));

            return app.UseMiddleware<FExceptionHandlerMiddelware>();
        }
    }
}
