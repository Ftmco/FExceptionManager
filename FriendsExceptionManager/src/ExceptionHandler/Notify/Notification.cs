using ExceptionHandler.Events;
using ExceptionHandler.Tools;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler.Notify
{
    public partial class Notification
    {
        private async void ExceptionOccurred()
        {
            IConfigurationSection section = Configuration.GetSection("FEH");
           
        }
    }

    public partial class Notification
    {
        private readonly IExceptionEvents _event;
        private readonly IEmailSender _email;

        public IConfiguration Configuration { get; set; }

        public Notification()
        {
            _email = new EmailSender();
            _event = new ExceptionEvents();
            _event.ExceptionOccurred += ExceptionOccurred;
        }
    }
}

