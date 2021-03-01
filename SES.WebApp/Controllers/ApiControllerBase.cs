using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SES.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public abstract class ApiControllerBase<T> : ControllerBase
        where T : class
    {
        public ApiControllerBase(ILogger<T> logger)
        {
            Logger = logger;
        }
        protected ILogger<T> Logger { get; }
    }
}
