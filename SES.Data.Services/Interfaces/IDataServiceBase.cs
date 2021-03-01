using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SES.Data.Services.Interfaces
{
    public interface IDataServiceBase
    {
        void Attach(object o, bool isModified = false);
        Task SaveAsync();
    }
}
