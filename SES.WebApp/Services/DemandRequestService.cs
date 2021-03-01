using Microsoft.Extensions.Logging;
using SES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES.WebApp.Services
{
    public class DemandRequestService : ServiceBase<DemandRequestService>, Interfaces.IDemandRequestService
    {
        public DemandRequestService(ILogger<DemandRequestService> logger, 
            Data.Services.Interfaces.IDemandRequestDataService demandRequestDataService)
            :base (logger)
        {
            DemandRequestDataService = demandRequestDataService;
        }
        private Data.Services.Interfaces.IDemandRequestDataService DemandRequestDataService { get; }
        public async Task<IEnumerable<DemandRequest>> LoadListAsync()
        {
            return await DemandRequestDataService.LoadListAsync();
        }

        public async Task AddRequestAsync(DemandRequest demandRequest)
        {
            DemandRequestDataService.Attach(demandRequest);
           await DemandRequestDataService.SaveAsync();
        }
    }
}
