using SES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES.WebApp.Services.Interfaces
{
    public interface IDemandRequestService : IServiceBase
    {
        Task<IEnumerable<DemandRequest>> LoadListAsync();

        Task AddRequestAsync(DemandRequest demandRequest);
    }
}
