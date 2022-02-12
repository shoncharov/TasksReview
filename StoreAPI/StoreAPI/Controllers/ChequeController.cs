using Microsoft.AspNetCore.Mvc;
using StoreAPI.Models;
using StoreAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Controllers
{
    public class ChequeController : Controller
    {
        //при такой зависимости при формировании запроса данный контроллер поймет, 
        //что необходимо вызывать именно эту реализацию
        private IChequeRepository cheque;

        public ChequeController(IChequeRepository cheq)
        {
            cheque = cheq;
        }


    }
}
