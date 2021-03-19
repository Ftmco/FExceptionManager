using Microsoft.AspNetCore.Builder;
using Middlewar.Middleware;
using System;

namespace Middlewar.MiddlewarExpression
{
    public static class MiddlewarApiExtentionExceptionHandler
    {
        public static IApplicationBuilder UseFExceptionHandlerApi(this IApplicationBuilder app)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            return app.UseMiddleware<FExceptionApiHandlerMiddleware>();
        }
    }
}
