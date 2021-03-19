using FTeam.Middlewar.Models;
using FTeam.Middlewar.StaticVarables;
using Microsoft.AspNetCore.Builder;
using System;

namespace FTeam.Middlewar
{
    public static class MiddlewarApiExtentionExceptionHandler
    {
        public static IApplicationBuilder UseFExceptionHandlerApi(this IApplicationBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<FExceptionApiHandlerMiddleware>();
        }

        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, string errorHandelingPath)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            StaticVariablesApi.ErrorHandeligPathApi = errorHandelingPath ??
                throw new ArgumentNullException(nameof(errorHandelingPath));

            return app.UseMiddleware<FExceptionApiHandlerMiddleware>();
        }

        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, FTServerEmailOptions emailOptions)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            StaticVariablesApi.FTServerEmailOptionsApi = emailOptions ??
                throw new ArgumentNullException(nameof(emailOptions));

            return app.UseMiddleware<FExceptionApiHandlerMiddleware>();
        }

        public static IApplicationBuilder UseFExceptionHandler(this IApplicationBuilder app, FTExceptionHandlerOptions exceptionHandlerOptions)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            StaticVariablesApi.FTExceptionHandlerOptionsApi = exceptionHandlerOptions ??
                throw new ArgumentNullException(nameof(exceptionHandlerOptions));

            return app.UseMiddleware<FExceptionApiHandlerMiddleware>();
        }
    }
}
