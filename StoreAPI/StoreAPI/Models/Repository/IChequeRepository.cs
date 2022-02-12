using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models.Repository
{
    public  interface IChequeRepository:IRepositoryBase<Cheque>
    {
        IQueryable<Cheque> cheques { get; }
    }
}
