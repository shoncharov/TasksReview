using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models.Repository
{
    public interface IItemRepository : IRepositoryBase<Item>
    {
        IQueryable<Item> Items { get; }
    }
}
