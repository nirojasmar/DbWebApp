using Bogus;
using DbWebApplication.Models;
using DbWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {       
        [HttpGet]
        public ActionResult <IEnumerable<ProductModel>> Index()
        {
            ProductsDAO products = new ProductsDAO();

            return products.GetAllProducts();
        }

        [HttpDelete("Delete/{Id}")]
        public ActionResult <int> Delete(int Id)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Delete(Id);

            return result;
        }

        [HttpPost("Create")]
        //expecting a product in json in the body of request
        public ActionResult <int> Create(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Insert(product);

            return result;
        }
    
        [HttpGet("searchresults/{searchTerm}")]
        public ActionResult <IEnumerable<ProductModel>> searchResults(String searchTerm)
        {
            ProductsDAO products = new ProductsDAO();

            return products.SearchProducts(searchTerm);
        }

        [HttpGet("Details/{Id}")]
        public ActionResult <ProductModel> Details(int Id)
        {
            ProductsDAO products = new ProductsDAO();

            return products.GetProductById(Id);
        }

        [HttpPut("Edit")]
        public ActionResult <ProductModel> Edit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();

            products.Update(product);

            return products.GetProductById(product.Id);
        }

        /* (Not Implemented)
        public IActionResult Truncate()
        {
            ProductsDAO products = new ProductsDAO();

            products.Truncate();

            return View("Index");
        }*/
    }
}
