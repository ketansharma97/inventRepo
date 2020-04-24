using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Invent.Models
{
    [Table("Shopkeeper")]
    public class Shopkeeper
    {
       

        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Enter Name of the Product")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Enter Price of the Product")]
        public string ProductPrice { get; set; }

        [Required(ErrorMessage = "Enter Quantity of the Product")]
        public string Quantity { get; set; }

        [Required(ErrorMessage = "Enter Date of the Product")]
        public string Date { get; set; }

    }
}
