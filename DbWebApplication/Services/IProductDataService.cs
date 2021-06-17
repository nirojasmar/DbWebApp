using DbWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Services
{
    interface IProductDataService
    {
        //Basic CRUD App Actions
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);
        int Insert(ProductModel product);
        int Delete(int Id);
        int Update(ProductModel product);
        int Truncate();
    }
}
