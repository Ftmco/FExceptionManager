using ExceptionHandler.Events;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Services.GenericRepository.ServicesController;
using System;
using System.Threading.Tasks;

namespace ExceptionHandler.Handler
{
    public class CallExceptions : ICallExceptions
    {
        #region __Dependency__

        /// <summary>
        /// Crud Services Manager 
        /// Created In Friends Team
        /// </summary>
        private readonly IServiceController<Exceptions, ExceptionsDbContext> _services;

        /// <summary>
        /// Exception Events
        /// </summary>
        private readonly IExceptionEvents _event;

        private IConfiguration Configuration { get; }

        /// <summary>
        /// Call Exceptions Constractor
        /// </summary>
        public CallExceptions()
        {
            _services = new ServiceController<Exceptions, ExceptionsDbContext>();
            _event = new ExceptionEvents(Configuration);
        }

        #endregion

        /// <summary>
        /// When Exception Ouccurred
        /// </summary>
        /// <param name="exception">Exception Detail</param>
        /// <param name="httpContext">Http Context</param>
        /// <returns></returns>
        public async Task OnExceptionOccurred(Exception exception, HttpContext httpContext) => await Task.Run(async () =>
        {
            //Create New Exception Entity Object
            Exceptions newException = new()
            {
                Date = DateTime.Now,
                InnerException = exception.InnerException?.Message,
                Message = exception.Message,
                Path = httpContext.Request.Path,
                RemoteConnectionIpAddress = httpContext.Connection.RemoteIpAddress.ToString(),
                Source = exception.Source,
                StackTrace = exception.StackTrace
            };

            //Insert Exception To Db
            await _services.Services.InsertAsync(newException);
            //Save changes
            await _services.SaveAsync();
            //Invoke Event
            await _event.InvokeEventAsync(this, new ExceptionEventArgs { Exception = newException });
        });

    }
}
