using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCore.Models.Db;
using Microsoft.EntityFrameworkCore;
using ShoppingCore.Models;

namespace ShoppingCore.Controllers
{
    public class HomeController : Controller
    {
        readonly ShoppingContext _db;
        public HomeController(ShoppingContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ListPhone = _db.Products.Where(n => n.CategoryId == 2);
            ViewBag.ListPhone = ListPhone;

            var ListLaptop = _db.Products.Where(n => n.CategoryId == 3);
            ViewBag.ListLaptop = ListLaptop;

            var ListTab = _db.Products.Where(n => n.CategoryId == 4);
            ViewBag.ListTab = ListTab;
            return View();
        }
       
    }
}