using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Alpaca_Burguer.Business.Models;


namespace Alpaca_Burguer.Application.Ingredients.CreateIngredient
{
    public class CreateIngredientRequest : IRequest<Ingredient>
    {
        public Ingredient Ingredient { get; set; }
    }
}
