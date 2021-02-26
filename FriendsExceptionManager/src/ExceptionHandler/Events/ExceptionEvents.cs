using System;
using System.Threading.Tasks;

namespace ExceptionHandler.Events
{
    /// <summary>
    /// Exception Event Delegate
    /// </summary>
    public delegate void ExceptionEventDelegate(object sender);


    /// <summary>
    /// Exception Event Controller  
    /// </summary>
    public interface IExceptionEvents
    {
        /// <summary>
        /// Exception Occerrud Event
        /// </summary>
        event ExceptionEventDelegate ExceptionOccurred;

        /// <summary>
        /// Inoke Event Excetpion 
        /// Use 'await' Before Call This
        /// </summary>
        Task InvokeEventAsync(object sender);
    }

    /// <summary>
    /// Exception Event Service
    /// </summary>
    public class ExceptionEvents : IExceptionEvents
    {
        public event ExceptionEventDelegate ExceptionOccurred;

        public async Task InvokeEventAsync(object sender) => await Task.Run(() => ExceptionOccurred.Invoke(sender));
    }

}
