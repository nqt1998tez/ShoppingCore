using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCore.Models.Db;
using ShoppingCore.Models.ViewModels;
using ShoppingCore.Services;

namespace ShoppingCore.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController(ShoppingContext db, CategoryService categoryService) : base(db, categoryService)
        {
        }
        public IActionResult Index(int? producerId)
        {
            this.BuildMenuViewData();
            if (producerId == null)
            {
                ViewData["Message"] = "Not found product";

            }
            else
            {
                ViewData["Message"] = "View all products of " + producerId;
            }


            return View();
        }

    }
}