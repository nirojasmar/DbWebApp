using Bogus;
using DbWebApplication.Models;
using DbWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace DbWebApplication.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProductControllerAPI : ControllerBase
    {       
        [HttpGet]
        [ResponseType(typeof(List<ProductModelDTO>))]
        public IEnumerable<ProductModelDTO> Index()
        {
            ProductsDAO products = new ProductsDAO();

            List<ProductModel> productList = products.GetAllProducts();

            IEnumerable<ProductModelDTO> productsDTO = from p in productList select new ProductModelDTO(p);

            return productsDTO;
        }

        [HttpDelete("Delete/{Id}")]
        public ActionResult <int> Delete(int Id)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Delete(Id);

            return result;
        }

        [HttpPost("Create")]
        //Expecting a product in json in the body of request
        public ActionResult <int> Create(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Insert(product);

            return result;
        }
    
        [HttpGet("searchresults/{searchTerm}")]
        [ResponseType(typeof(List<ProductModelDTO>))]
        public IEnumerable<ProductModelDTO> searchResults(String searchTerm)
        {
            ProductsDAO products = new ProductsDAO();

            List<ProductModel> productList = products.SearchProducts(searchTerm);

            IEnumerable<ProductModelDTO> productsDTO = from p in productList select new ProductModelDTO(p);

            return productsDTO;
        }

        [HttpGet("Details/{Id}")]
        public ActionResult <ProductModelDTO> Details(int Id)
        {

            ProductsDAO products = new ProductsDAO();

            ProductModel p = products.GetProductById(Id);

            ProductModelDTO pDTO = new ProductModelDTO(p);

            return pDTO;
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
