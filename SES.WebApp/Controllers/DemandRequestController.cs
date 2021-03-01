using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SES.Data.Models;

namespace SES.WebApp.Controllers
{
    public class DemandRequestController : ApiControllerBase<DemandRequestController>
    {
        public DemandRequestController(ILogger<DemandRequestController> logger,
            Services.Interfaces.IDemandRequestService demandRequestService) : base(logger)
        {
            DemandRequestService = demandRequestService;
        }
        private Services.Interfaces.IDemandRequestService DemandRequestService { get; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await DemandRequestService.LoadListAsync());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(DemandRequest demandRequest)
        {
            try
            {
                demandRequest.Status = "New";
                demandRequest.Date = DateTime.Today;
                await DemandRequestService.AddRequestAsync(demandRequest);

                return Ok(await DemandRequestService.LoadListAsync());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
