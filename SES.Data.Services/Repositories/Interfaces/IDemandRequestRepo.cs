using SES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SES.Data.Services.Repositories.Interfaces
{
    public interface IDemandRequestRepo : IRepoBase
    {
        Task<IEnumerable<DemandRequest>> LoadListAsync(params Expression<Func<DemandRequest, object>>[] includeEntities);
    }
}
