using FTeam.Middlewar.Models;
using FTeam.Middlewar.StaticVarables;
using Microsoft.AspNetCore.Builder;
using System;

//Friends Team Co Develop this Pakacge 
//You Can See Other Packages  In https://Github.com/ftmco Or See https://friendstmco.ir
//Friends Team #Love_Open_Source 

namespace FTeam.Middlewar
{
    /// <summary>
    /// Restfull Api Exception Handler Middleware
    /// </summary>
    public static class MiddlewarApiExtentionExceptionHandler
    {
        /// <summary>
        /// Use Friends Exception Handler For Rest Api 
        /// </summary>
        /// <param name="app">IApplicationBuilder </param>
        public static IApplicationBuilder UseFExceptionHandlerApi(this IApplicationBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<FExceptionApiHandlerMiddleware>();
        }

        /// <summary>
        /// Use Friends Exception Handler For Rest Api 
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="errorHandelingPath">Redirect Controller and Action To Return Response For Client</param>
        public static IApplicationBuilder UseFExceptionHandlerApi(this IApplicationBuilder app, string errorHandelingPath)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            StaticVariablesApi.ErrorHandeligPathApi = errorHandelingPath ??
                throw new ArgumentNullException(nameof(errorHandelingPath));

            return app.UseFExceptionHandlerApi();
        }

        /// <summary>
        /// Use Friends Exception Handler For Rest Api 
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="emailOptions">Send Error Log Email Options</param>
        public static IApplicationBuilder UseFExceptionHandlerApi(this IApplicationBuilder app, FTServerEmailOptions emailOptions)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            StaticVariablesApi.FTServerEmailOptionsApi = emailOptions ??
                throw new ArgumentNullException(nameof(emailOptions));

            return app.UseFExceptionHandlerApi();
        }

        /// <summary>
        /// Use Friends Exception Handler For Rest Api 
        /// </summary>
        /// <param name="app">IApplicationBuilder</param>
        /// <param name="exceptionHandlerOptions">Exception Handler Email and Redirect Path Options</param>
        public static IApplicationBuilder UseFExceptionHandlerApi(this IApplicationBuilder app, FTExceptionHandlerOptions exceptionHandlerOptions)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            StaticVariablesApi.FTExceptionHandlerOptionsApi = exceptionHandlerOptions ??
                throw new ArgumentNullException(nameof(exceptionHandlerOptions));

            return app.UseFExceptionHandlerApi();
        }
    }
}
