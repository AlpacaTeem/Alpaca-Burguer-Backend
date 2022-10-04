using Alpaca_Burguer.Business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Application
{
    public class GetIngredientRequest : IRequest<Ingredient>
    {
        public Guid Id { get; set; }
    }
}
