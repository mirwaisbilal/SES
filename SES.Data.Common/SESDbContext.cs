using Microsoft.EntityFrameworkCore;
using SES.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace SES.Data.Models
{
    public class SESDbContext: DbContext
    {
        public SESDbContext(DbContextOptions<SESDbContext> options) : base(options)
        {

        }
        public virtual DbSet<DemandRequest> DemandRequests { get; set; }
    }
}
