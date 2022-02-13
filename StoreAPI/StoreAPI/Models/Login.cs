using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Login 
    {
        // entity only for Login Form 
        public int Id { get; set; }
        [Required]
        public string LoginOwn { get; set; }
        [Required]
        public string PasswordOwn { get; set; }

    }
}
