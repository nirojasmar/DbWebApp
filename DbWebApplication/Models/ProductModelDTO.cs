using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Models
{
    public class ProductModelDTO
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public String PriceString { get; set; }

        public String Description { get; set; }

        public String ShortDescription { get; set; }

        public decimal Tax { get; set; }

        public ProductModelDTO(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;

            PriceString = string.Format("{0:C}", price);
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.08M;
        }

        // Alternative CTOR

        public ProductModelDTO(ProductModel product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Description = product.Description;

            PriceString = string.Format("{0:C}", product.Price);
            ShortDescription = product.Description.Length <= 25 ? product.Description : product.Description.Substring(0, 25);
            Tax = product.Price * 0.08M;
        }
    }
}
