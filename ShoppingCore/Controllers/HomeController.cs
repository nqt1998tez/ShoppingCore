using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCore.Models.Db;
using Microsoft.EntityFrameworkCore;
using ShoppingCore.Models;
using ShoppingCore.Services;
using ShoppingCore.Models.ViewModels;

namespace ShoppingCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShoppingContext _db;
        private readonly CategoryService _categoryService;
        public HomeController(ShoppingContext db,CategoryService categoryService)
        {
            this._db = db;
            this._categoryService = categoryService;
        }
        public IActionResult Index()
        {

            var ListPhone = _db.Products.Where(n => n.CategoryId == 2);
            ViewBag.ListPhone = ListPhone;

            var ListLaptop = _db.Products.Where(n => n.CategoryId == 3);
            ViewBag.ListLaptop = ListLaptop;

            var ListTab = _db.Products.Where(n => n.CategoryId == 4);
            ViewBag.ListTab = ListTab;
            List<CategoryViewModel> Menu_Category = _categoryService.GetCategories();
            List<MenuViewModel> Menu = new List<MenuViewModel>();

            foreach (var item in Menu_Category)
            {
                var MenuItem = new MenuViewModel();
                MenuItem.CategoryId = item.CategoryId;
                MenuItem.CategoryName = item.Name;
                MenuItem.Producers = _categoryService.GetProductByCategoryId(item.CategoryId);
                Menu.Add(MenuItem);
            }

            ViewData["Menu_Category"] = Menu_Category;
            ViewData["Menu"] = Menu;
            
            return View();
        }
    }
}