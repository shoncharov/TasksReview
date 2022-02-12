using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models.Repository
{
   public interface ILoginRepository : IRepositoryBase<Login>
    {
        IQueryable<Login> Logins { get; }
        
    }
}
