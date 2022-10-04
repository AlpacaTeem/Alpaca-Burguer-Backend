using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application.Ingredients.DeleteIngredient
{
    public class DeleteIngredientHandler : IRequestHandler<DeleteIngredientRequest, Ingredient>
    {
        private IIngredientRepository _ingredientRepository;

        public DeleteIngredientHandler(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public Task<Ingredient> Handle(DeleteIngredientRequest request, CancellationToken cancellationToken)
        {
            return _ingredientRepository.Delete(request.Id);
        }
    }
}
