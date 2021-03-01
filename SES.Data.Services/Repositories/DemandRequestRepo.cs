using Microsoft.EntityFrameworkCore;
using SES.Data.Models;
using SES.Data.Services.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SES.Data.Services.Repositories
{
    public class DemandRequestRepo : RepositoryBase<DemandRequestRepo>, IDemandRequestRepo
    {
        public DemandRequestRepo(SESDbContext sESDbContext) : base (sESDbContext)
        { }

        public async Task<IEnumerable<DemandRequest>> LoadListAsync(params Expression<Func<DemandRequest, object>>[] includeEntities)
        {
            try
            {
                return await SESDbContext.DemandRequests.ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
