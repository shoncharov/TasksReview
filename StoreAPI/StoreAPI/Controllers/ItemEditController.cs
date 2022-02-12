using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Controllers
{
    public class ItemEditController : Controller
    {   
                private ItemEditController items { get; } 
        public ItemEditController(ItemEditController item)
        {
            items = item;
        }

    }
}
