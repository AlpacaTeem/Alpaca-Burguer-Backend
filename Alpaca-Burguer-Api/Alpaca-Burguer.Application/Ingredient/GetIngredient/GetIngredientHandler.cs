using Alpaca_Burguer.Application.Interfaces;
using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application
{
    public class GetIngredientHandler : IRequestHandler<GetIngredientRequest, Ingredient>
    {
        private IIngredientRepository _ingredientRepository;

        public GetIngredientHandler(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public Task<Ingredient> Handle(GetIngredientRequest request, CancellationToken cancellationToken)
        {
            return _ingredientRepository.Get(request.Id);
        }
    }
}
