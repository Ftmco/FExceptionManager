using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ExceptionHandler.Handler
{
    /// <summary>
    /// Exception Handler Middleware
    /// </summary>
    public class ExceptionHandler
    {
        /// <summary>
        /// Request
        /// </summary>
        private readonly RequestDelegate _request;

        /// <summary>
        /// Exceotion Services
        /// </summary>
        private readonly ICallExceptions _callExceptions;

        /// <summary>
        /// Exception Handler Middleware
        /// </summary>
        /// <param name="request">RequestDelegate</param>
        public ExceptionHandler(RequestDelegate request)
        {
            _request = request;
            _callExceptions = new CallExceptions();
        }

        /// <summary>
        /// Run 
        /// </summary>
        /// <param name="context">Http Context</param>
        public async Task Invoke(HttpContext context)
        {
            //Run Application
            try
            {
                await _request(context);
            }
            //Excepption Occerrud
            catch (Exception ex)
            {
                //Call Event and Log Exception To Data Base
                await _callExceptions.OnExceptionOccurred(ex, context);

                //Redirect Request To 500 Internal Server Error Page
                context.Response.Redirect("/500err");

                //Run Application
                await _request(context);
            }
        }
    }
}
