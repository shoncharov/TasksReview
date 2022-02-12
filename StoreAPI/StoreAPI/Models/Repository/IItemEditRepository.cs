using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models.Repository
{
    public interface IItemEditRepository : IRepositoryBase<ItemEdit>
    {
        IQueryable<ItemEdit> ItemEdits { get; }
    }
}
