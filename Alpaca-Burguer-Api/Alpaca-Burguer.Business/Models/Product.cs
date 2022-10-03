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

        public Product(string name, double margemDeLucroVisada, string description, double preco, List<Ingredient> ingredients)
        {
            Name = name;
            Description = description;
            MargemDeLucroVisada = margemDeLucroVisada;
            Preco = preco;
            Ingredients = ingredients;
            Updated = DateTime.Now;
        }
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
