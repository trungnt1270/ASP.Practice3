using ProductManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManage.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID=1,
                    Name = "Product 1",
                    Price = 50,
                    Quantity = 1,
                    ReleaseDate = DateTime.Now,
                    CategoryID = 1,
                }
            };
        }
    }
}