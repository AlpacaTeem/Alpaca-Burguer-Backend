using Alpaca_Burguer.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Data.DbContexts
{
    public class AlpacaBurguerDbContext : DbContext
    {
        public AlpacaBurguerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
