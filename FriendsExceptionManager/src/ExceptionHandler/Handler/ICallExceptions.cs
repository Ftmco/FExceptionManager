using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ExceptionHandler.Handler
{
    public interface ICallExceptions
    {
        Task OnExceptionOccurred(Exception exception,HttpContext httpContext);
    }
}
