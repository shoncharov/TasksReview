using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> Get();

        void Put(T ent);
        void Post(T ent);
        void Delete(T ent);

        

    }
}
