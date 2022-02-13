using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Cheque
    {
        public int Id { get; set; }
        public int Bayer { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public decimal  Price { get; set; }
        [Required]
        public decimal SumPrice { get; set; }

        //nav
       
        public ICollection<Item> Items { get; set; }





    }
}
