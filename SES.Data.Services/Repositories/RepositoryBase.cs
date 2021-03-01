using SES.Data.Models;
using SES.Data.Services.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SES.Data.Services.Repositories
{
    public class RepositoryBase<TRepo> : IRepoBase
        where TRepo: class
    {
        public RepositoryBase(SESDbContext sESDbContext)
        {
            SESDbContext = sESDbContext;
        }

        public SESDbContext SESDbContext { get; }
    }
}
