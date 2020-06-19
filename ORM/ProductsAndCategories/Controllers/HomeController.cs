using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAndCategories.Models;

namespace ProductsAndCategories.Controllers
{
    public class HomeController : Controller
    {
        private ProductsAndCategoriesContext db;
        public HomeController(ProductsAndCategoriesContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = db.Products.ToList();
            return View("Products");
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = db.Categories.ToList();
            return View("Categories");
        }

        [HttpGet("product/create")]
        public IActionResult NewProduct()
        {
            return View("NewProduct");
        }

        [HttpPost("product/create")]
        public IActionResult CreateProduct(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                db.Add(newProduct);
                int SavedProductId = db.SaveChanges();

                // Console.WriteLine(newProduct.ProductId);
                // Console.WriteLine(SavedProductId);

                return Redirect($"/product/{newProduct.ProductId}");
                // return RedirectToAction("SingleProduct", new { productId = newProduct.ProductId });
            }
            return View("NewProduct", newProduct);
        }

        [HttpGet("category/create")]
        public IActionResult NewCategory()
        {
            return View("NewCategory");
        }
        [HttpPost("category/create")]
        public IActionResult CreateCategory(Category newCategory)
        {
            if (ModelState.IsValid)
            {
                db.Add(newCategory);
                int SavedCategoryId = db.SaveChanges();

                return Redirect($"/product/{newCategory.CategoryId}");

            }
            return View("Categories");
        }

        [HttpGet("product/{productId}")]
        public IActionResult SingleProduct(int productId)
        {
            var ProductWithCategories = db.Products
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == productId);

            List<Category> AllCategories = db.Categories
                .Include(c => c.Products)
                .ThenInclude(a => a.Product)
                .Where(c => c.Products.All(a => a.Product.ProductId != productId)).ToList();

            ProductWrapper SingleProduct = new ProductWrapper();
            SingleProduct.Product = ProductWithCategories;
            SingleProduct.AllCategoriesForProduct = AllCategories;

            return View("SingleProduct", SingleProduct);
        }

        [HttpGet("category/{categoryId}")]
        public IActionResult SingleCategory(int categoryId)
        {
            var CategoryWithProducts = db.Categories
                .Include(c => c.Products)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(c => c.CategoryId == categoryId);


            List<Product> AllProducts = db.Products
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .Where(p => p.Categories.All(a => a.Category.CategoryId == categoryId)).ToList();

            CategoryWrapper SingleCategory = new CategoryWrapper();
            SingleCategory.Category = CategoryWithProducts;
            SingleCategory.AllProductsForCategory = AllProducts;

            return View("SingleCategory", SingleCategory);
        }

        [HttpPost("product/{productId}/update")]
        public IActionResult AddCategoryToProduct(int categoryIdToAdd, int productId)
        {
            var RetrievedProduct = db.Products
                .Include(p => p.Categories)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == productId);

            var RetrievedCategory = db.Categories
                .FirstOrDefault(c => c.CategoryId == categoryIdToAdd);


            RetrievedProduct.Categories.Add(new Link
            {
                Product = RetrievedProduct,
                Category = RetrievedCategory
            });
            db.SaveChanges();
            return RedirectToAction("SingleProduct", new { productId = productId });
        }

        [HttpPost("category/{categoryId}/update")]
        public IActionResult AddProductToCategory(int productIdToAdd, int categoryId)
        {
            var RetrievedCategory = db.Categories
                .Include(p => p.Products)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(p => p.CategoryId == categoryId);

            var RetrievedProduct = db.Products
                .FirstOrDefault(p => p.ProductId == productIdToAdd);

            RetrievedCategory.Products.Add(new Link
            {
                Category = RetrievedCategory,
                Product = RetrievedProduct
            });

            db.SaveChanges();
            return RedirectToAction("SingleCategory", new { categoryId = categoryId });
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
