using FTeam.Middlewar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTeam.Middlewar.Services
{
    public interface IExceptionHanlder
    {
        Task ExceptionOccreuudAsync(EmailModel emailModel);
    }
}
