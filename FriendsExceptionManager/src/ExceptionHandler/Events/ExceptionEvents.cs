using ExceptionHandler.Tools;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ExceptionEvents()
        {
            _email = new EmailSender();
            ExceptionOccurred += OnExceptionOccurred;
        }

        private async void OnExceptionOccurred(object sender, ExceptionEventArgs e)
        {
            string stringJson = File.ReadAllText("/appsettings.json");
            if (!string.IsNullOrEmpty(stringJson))
            {
                object json = JsonConvert.DeserializeObject(stringJson);
                await _email.SendEmailAsync(new EmailViewModel
                {
                    Body = $"Message : {e.Exception.Message} \n Inner Exception : {e.Exception.InnerException} \n Source : {e.Exception.Source} \n Path : {e.Exception.Path} \n Date Time : {e.Exception.Date}",
                    DisplayName = "Exception Occerrud",
                    IsBodyHtml = true,
                    Subject = "Application Has Exception",

                });
            }
        }

        public async Task InvokeEventAsync(object sender, ExceptionEventArgs e) => await Task.Run(() =>
            ExceptionOccurred?.Invoke(sender, e));
    }


    public class ExceptionEventArgs : EventArgs
    {
        public Exceptions Exception { get; set; }
    }

}
