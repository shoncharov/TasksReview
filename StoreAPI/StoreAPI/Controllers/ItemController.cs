using StoreAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace StoreAPI.Controllers
{
    public class ItemController : Controller
    { private IItemRepository repository { get; }
        public ItemController(IItemRepository rep)
        {
            repository = rep;
        }

       

    }
}
