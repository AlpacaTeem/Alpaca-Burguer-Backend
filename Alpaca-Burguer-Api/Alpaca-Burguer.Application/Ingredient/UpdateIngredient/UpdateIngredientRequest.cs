using Alpaca_Burguer.Business.Models;
using MediatR;

namespace Alpaca_Burguer.Application
{
    public class UpdateIngredientRequest : IRequest<Ingredient>
    {
        public Ingredient Ingredient { get; set; }
    }
}
