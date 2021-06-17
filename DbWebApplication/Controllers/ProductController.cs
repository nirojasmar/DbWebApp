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
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductsDAO products = new ProductsDAO();

            return View(products.GetAllProducts());
        }

        public IActionResult Create()
        { 
            return View();
        }

        public IActionResult Delete(int Id)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Delete(Id);

            if (result >= 1)
            {
                return View("DeleteSuccessful", Id);
            }
            else
            {
                return View("DeleteDenied");
            }
        }

        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Insert(product);

            if (result >= 1)
            {
                return View("CreateSuccessful", product);
            }
            else
            {
                return View("Create");
            }
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult searchResults(String searchTerm)
        {
            ProductsDAO products = new ProductsDAO();

            List<ProductModel> productList = products.SearchProducts(searchTerm);
            return View("Index", productList);
        }
        public IActionResult Edit(int Id)
        {
            ProductsDAO products = new ProductsDAO();

            ProductModel product = new ProductModel();

            product = products.GetProductById(Id);

            return View("Edit" , product);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDAO products = new ProductsDAO();

            int result = products.Update(product);

            if(result == 1)
            {
                return View("EditSuccessful", product);
            }
            else
            {
                return View("EditDenied");
            }
        }
    }
}
