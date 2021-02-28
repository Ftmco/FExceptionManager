using ExceptionHandler.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExceptionHandler.Events
{
    /// <summary>
    /// Exception Event Delegate
    /// </summary>
    public delegate void ExceptionEventDelegate(object sender, ExceptionEventArgs e);


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
        Task InvokeEventAsync(object sender, ExceptionEventArgs e);
    }

    /// <summary>
    /// Exception Event Service
    /// </summary>
    public class ExceptionEvents : IExceptionEvents
    {
        public event ExceptionEventDelegate ExceptionOccurred;

        private readonly IEmailSender _email;

        public IConfiguration Configuration { get; set; }

        public ExceptionEvents(IConfiguration configuration)
        {
            Configuration = configuration;
            _email = new EmailSender();
            ExceptionOccurred += OnExceptionOccurred;
        }

        private async void OnExceptionOccurred(object sender, ExceptionEventArgs e)
        {
            JsonDocument jsonDocument = new();
            if (section != null)
            {
                IEnumerable<IConfigurationSection> sectionChilderns = section.GetChildren();
                await _email.SendEmailAsync(new EmailViewModel
                {

                });
            }
        }

        public async Task InvokeEventAsync(object sender, ExceptionEventArgs e) => await Task.Run(() =>
        {
            ExceptionOccurred?.Invoke(sender, e);

        });
    }


    public class ExceptionEventArgs : EventArgs
    {
        public Exceptions Exception { get; set; }
    }

}
