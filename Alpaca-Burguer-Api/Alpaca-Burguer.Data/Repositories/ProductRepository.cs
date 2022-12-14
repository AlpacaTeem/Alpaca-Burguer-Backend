using Alpaca_Burguer.Business.Models;
using Alpaca_Burguer.Data.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Data.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(AlpacaBurguerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
