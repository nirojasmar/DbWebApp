using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public String Description { get; set; }
    }
}
