using Microsoft.Extensions.Logging;
using SES.Data.Models;
using SES.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SES.Data.Services
{
    public class DataServiceBase<TService> : IDataServiceBase
        where TService : class
    {
        public DataServiceBase(ILogger<TService> logger, SESDbContext sESDbContext)
        {
            Logger = logger;
            SESDbContext = sESDbContext;
        }
        protected ILogger<TService> Logger { get; }
        protected SESDbContext SESDbContext { get; }

        public void Attach(object o, bool isModified = false)
        {
            SESDbContext.Attach(o);
            if (isModified && SESDbContext.Entry(o).State == Microsoft.EntityFrameworkCore.EntityState.Unchanged)
            {
                SESDbContext.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }
        public async Task SaveAsync()
        {
            try
            {
                await SESDbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
