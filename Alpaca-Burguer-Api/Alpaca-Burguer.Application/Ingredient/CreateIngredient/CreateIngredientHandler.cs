using Alpaca_Burguer.Business.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Alpaca_Burguer.Business.Models;

namespace Alpaca_Burguer.Application
{
    public class CreateIngredientHandler : IRequestHandler<CreateIngredientRequest, Ingredient>
    {
        private IIngredientRepository _ingredientRepository;

        public CreateIngredientHandler(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public Task<Ingredient> Handle(CreateIngredientRequest request, CancellationToken cancellationToken)
        {
            return _ingredientRepository.Add(request.Ingredient);
        }
    }

}

