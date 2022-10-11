using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application
{
    internal class GetAllIngredientHistoryHandler : IRequestHandler<GetAllIngredientHistoryRequest, List<IngredientHistory>>
    {
        private IRepository<IngredientHistory> _ingredientHistoryRepository;

        public GetAllIngredientHistoryHandler(IRepository<IngredientHistory> ingredientHistoryRepository)
        {
            _ingredientHistoryRepository = ingredientHistoryRepository;
        }

        public Task<List<IngredientHistory>> Handle(GetAllIngredientHistoryRequest request, CancellationToken cancellationToken)
        {
            return _ingredientHistoryRepository.GetAll();
        }
    }
}
