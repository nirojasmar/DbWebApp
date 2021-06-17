using Bogus;
using DbWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Services
{
    public class HardCodedSampleDataRepo : IProductDataService
    {
        static List<ProductModel> productsList = new List<ProductModel>();
        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if(productsList.Count == 0)
            {
                productsList.Add(new ProductModel { Id = 1, Name = "Mouse Pad", Price = 5.99m, Description = "A square plastic piece to give comfort" });
                productsList.Add(new ProductModel { Id = 2, Name = "Web Cam", Price = 45.50m, Description = "For your online meetings" });
                productsList.Add(new ProductModel { Id = 3, Name = "4 TB HDD", Price = 130.00m, Description = "A lot of space" });
                productsList.Add(new ProductModel { Id = 4, Name = "Mouse", Price = 15.99m, Description = "Dont use a track pad, please" });

                for (int i = 5; i < 100; i++)
                {
                    productsList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review())
                        );
                }
            }
            return productsList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
