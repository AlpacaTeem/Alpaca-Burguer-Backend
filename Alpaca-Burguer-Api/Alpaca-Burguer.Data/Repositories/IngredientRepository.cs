using Alpaca_Burguer.Business.Models;
using Alpaca_Burguer.Data.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Data.Repositories
{
    public class IngredientRepository : Repository<Ingredient>
    {
        public IngredientRepository(AlpacaBurguerDbContext dbContext) : base(dbContext)
        {
        }
    }
}
