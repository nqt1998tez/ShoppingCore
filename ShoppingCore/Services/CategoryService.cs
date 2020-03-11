using ShoppingCore.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using ShoppingCore.Models.ViewModels;

namespace ShoppingCore.Services
{
    public class CategoryService
    {
        private readonly Models.Db.ShoppingContext _db;
        public CategoryService(Models.Db.ShoppingContext db)
        {
            this._db = db;
        }
        public List<CategoryViewModel> GetCategories()
        {
            var categories = new List<CategoryViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                List<int> categoryIds = conn.Query<int>("select CategoryId from Product group by CategoryId").ToList();
                //var products = conn.Query<Product>("SELECT Name, Cost, UpdatedDate FROM Product").ToList();
                foreach (var item in categoryIds)
                {
                    var category = _db.Categories.FirstOrDefault(n => n.CategoryId == item);
                    categories.Add(new CategoryViewModel(category));
                }
                conn.Close();
            }
            return categories;
        }
        public List<ProducerViewModel> GetProductByCategoryId(int categoryId)
        {
            var Producers = new List<ProducerViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                Producers = conn.Query<ProducerViewModel>(@"
                                                            select p.*
                                                            from Producer p 
	                                                            join Product pd on p.ProducerId=pd.ProducerId
	                                                            join  Category c on pd.CategoryId=c.CategoryId
	                                                        where c.CategoryId="+categoryId).ToList();
                //var products = conn.Query<Product>("SELECT Name, Cost, UpdatedDate FROM Product").ToList();

                conn.Close();
            }
            return Producers;
        }
    }
}
