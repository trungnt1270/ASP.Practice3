using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using Microsoft.Ajax.Utilities;
using WAD_TrungNT.Models;

namespace WAD_TrungNT.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boats"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    Name = "Product 1",
                    Price = 50,
                    Quantity= 1000,
                    ReleaseDate = DateTime.Parse("2022-09-13"),
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    Name = "Product 2",
                    Price = 50,
                    Quantity= 1000,
                    ReleaseDate = DateTime.Parse("2022-09-01"),
                    CategoryID = 2
               }
            };

            return products;
        }
    }
}