using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application
{
    public class AddRowIngredientHistoryHandler : IRequestHandler<AddRowIngredientHistoryRequest, IngredientHistory>
    {
        private IRepository<IngredientHistory> _ingredientHistoryRepository;

        public AddRowIngredientHistoryHandler(IRepository<IngredientHistory> ingredientHistoryRepository)
        {
            _ingredientHistoryRepository = ingredientHistoryRepository;
        }

        public Task<IngredientHistory> Handle(AddRowIngredientHistoryRequest request, CancellationToken cancellationToken)
        {
            return _ingredientHistoryRepository.Add(request.IngredientItem);
        }
    }
}
