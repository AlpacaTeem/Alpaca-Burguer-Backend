using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application.Ingredients.DeleteIngredient
{
    public class DeleteIngredientRequest : IRequest<Ingredient>
    {
        public Guid Id { get; set; }
    }
}
