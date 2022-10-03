using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Business.Models
{
    public class IngredientHistory : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Preco { get; set; }

        public IngredientHistory(string name, string description, double preco)
        {
            Name = name;
            Description = description;
            Preco = preco;
        }
    }
    
}
