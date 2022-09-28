using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Business.Models
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double MargemDeLucroVisada { get; set; }
        public double Preco { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public double CalculatePrice()
        {
            foreach (var ingredient in Ingredients)
            {
                Preco += ingredient.Preco;
            }
            return Preco;
        }
    }
}
