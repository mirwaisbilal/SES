using SES.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SES.Data.Services.Interfaces
{
    public interface IDemandRequestDataService : IDataServiceBase
    {
        Task<IEnumerable<DemandRequest>> LoadListAsync(params Expression<Func<DemandRequest, object>>[] includeEntities);
    }
}
