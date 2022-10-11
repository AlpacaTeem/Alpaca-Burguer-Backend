using Alpaca_Burguer.Business.Models;
using MediatR;
using System.Collections.Generic;

namespace Alpaca_Burguer.Application
{
    public class GetAllIngredientHistoryRequest : IRequest<List<IngredientHistory>>
    {
    }
}
