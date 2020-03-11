using ShoppingCore.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string AliasName { get; set; }
        public string Brand { get; set; }
        public CategoryViewModel(Category category)
        {
            this.CategoryId = category.CategoryId;
            this.Name = category.Name;
            this.Icon = category.Icon;
            this.AliasName = category.AliasName;
            this.Brand = category.Brand;
        }
    }
}
