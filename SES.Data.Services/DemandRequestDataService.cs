using Microsoft.Extensions.Logging;
using SES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SES.Data.Services
{
    public class DemandRequestDataService : DataServiceBase<DemandRequestDataService>, Interfaces.IDemandRequestDataService
    {
        public DemandRequestDataService(ILogger<DemandRequestDataService> logger,
            SESDbContext sESDbContext,
            Repositories.Interfaces.IDemandRequestRepo demandRequestRepo) 
            :base (logger, sESDbContext)
        {
            DemandRequestRepo = demandRequestRepo;
        }

        private Repositories.Interfaces.IDemandRequestRepo DemandRequestRepo { get; }

        public async Task<IEnumerable<DemandRequest>> LoadListAsync(params Expression<Func<DemandRequest, object>> [] includeEntities)
        {
            try
            {
                return await DemandRequestRepo.LoadListAsync(includeEntities);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
