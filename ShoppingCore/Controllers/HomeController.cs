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
    public class HomeController : BaseController
    {
        
        public HomeController(ShoppingContext db, CategoryService categoryService) : base(db, categoryService) 
        { }
        public IActionResult Index()
        {
            BuildMenuViewData();

            return View();
        }

    }
}