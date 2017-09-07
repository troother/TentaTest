using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        { 
        var tv = new ProductCategory() { ProductCategoryId = 1, Name = "TV" };
        var dvd = new ProductCategory() { ProductCategoryId = 2, Name = "DVD" };
        var vhs = new ProductCategory() { ProductCategoryId = 3, Name = "VHS" };

        context.SaveChanges();
        }
    }
}
