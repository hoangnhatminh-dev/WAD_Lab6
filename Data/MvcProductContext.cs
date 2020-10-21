using Microsoft.EntityFrameworkCore;
using MvcProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProduct.Data
{
    public class MvcProductContext : DbContext
    {
        public MvcProductContext(DbContextOptions<MvcProductContext> options)
    : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
