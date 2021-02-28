using System;
using System.Threading.Tasks;

namespace ExceptionHandler.Events
{
    /// <summary>
    /// Exception Event Delegate
    /// </summary>
    public delegate void ExceptionEventDelegate(object sender, Exceptions email);


    /// <summary>
    /// Exception Event Controller  
    /// </summary>
    public interface IExceptionEvents
    {
        /// <summary>
        /// Exception Occerrud Event
        /// </summary>
        event ExceptionEventDelegate ExceptionOccurred;

        event EventHandler ExceptionOccurred2;

        /// <summary>
        /// Inoke Event Excetpion 
        /// Use 'await' Before Call This
        /// </summary>
        Task InvokeEventAsync(object sender, Exceptions email);
    }

    /// <summary>
    /// Exception Event Service
    /// </summary>
    public class ExceptionEvents : IExceptionEvents
    {
        public event ExceptionEventDelegate ExceptionOccurred;

        public event EventHandler ExceptionOccurred2;

        public async Task InvokeEventAsync(object sender, Exceptions email) => await Task.Run(() =>
        {

            ExceptionOccurred2(sender, new ExceptionEventArgs() { Exception = email });
        });
    }


    public class ExceptionEventArgs : EventArgs
    {
        public Exceptions Exception { get; set; }
    }

}
