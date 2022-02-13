using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI.Models
{
    public class Item
        //our item will be sneakers
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Brand { get; set; }
        [Required]
        public int Amount { get; set; }
        [StringLength(2)]
        public int Size { get; set; }
        [Required]
        public decimal Price { get; set; }
        //nav
        //public int ChequeId { get; set; }
        public Cheque  Cheque { get; set; }

    }
}
