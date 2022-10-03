using Alpaca_Burguer.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Data.Data.Mapping
{
    public class IngredientHistoryMapping : IEntityTypeConfiguration<IngredientHistory>
    {
        public void Configure(EntityTypeBuilder<IngredientHistory> builder)
        { 
        
        }
    }
}

