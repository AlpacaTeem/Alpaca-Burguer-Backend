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
    public class GetAllIngredientsHandler : IRequestHandler<GetAllIngredientsRequest, List<Ingredient>>
    {
        private IIngredientRepository _ingredientRepository;

        public GetAllIngredientsHandler(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public Task<List<Ingredient>> Handle(GetAllIngredientsRequest request, CancellationToken cancellationToken)
        {
            return _ingredientRepository.GetAll();
        }
    }
}
