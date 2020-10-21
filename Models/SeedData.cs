using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcProduct.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProduct.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProductContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcProductContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Title = "Product1",
                        Price = 7.99M
                    },

                    new Product
                    {
                        Title = "Product2",
                        Price = 8.99M
                    },

                    new Product
                    {
                        Title = "Product3",
                        Price = 9.99M
                    },

                    new Product
                    {
                        Title = "Product4",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
