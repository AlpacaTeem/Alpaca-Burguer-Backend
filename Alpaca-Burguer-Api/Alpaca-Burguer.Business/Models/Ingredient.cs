using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Business.Models
{
    public class Ingredient : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Preco { get; set; }

        public Ingredient(string name, string description , double preco)
        {
            Name = name;
            Description = description;
            Preco = preco;
            Updated = DateTime.Now;
        }
    }
}
