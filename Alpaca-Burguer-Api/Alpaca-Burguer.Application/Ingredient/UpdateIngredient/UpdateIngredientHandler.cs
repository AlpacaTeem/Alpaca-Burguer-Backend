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
    public class UpdateIngredientHandler : IRequestHandler<UpdateIngredientRequest, Ingredient>
    {
        private IIngredientRepository _IngredientRepository;

        public UpdateIngredientHandler(IIngredientRepository ingredientRepository)
        {
            _IngredientRepository = ingredientRepository;
        }

        public Task<Ingredient> Handle(UpdateIngredientRequest request, CancellationToken cancellationToken)
        {
            return _IngredientRepository.Update(request.Ingredient);
        }
    }
}
