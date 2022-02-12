using StoreAPI.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace StoreAPI.Controllers
{
    public class LoginController : Controller
    {
        private ILoginRepository login;

        public LoginController(ILoginRepository log)
        {
            login = log;
        }

        public void Show(string s)
        {
            Console.WriteLine(s);
        }
    }
}
