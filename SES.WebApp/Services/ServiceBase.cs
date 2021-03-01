using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES.WebApp.Services
{
    public class ServiceBase<T> : Interfaces.IServiceBase
        where T : class
    {
        public ServiceBase(ILogger<T> logger)
        {
            Logger = logger;
        }
        protected ILogger<T> Logger { get; }
    }
}
