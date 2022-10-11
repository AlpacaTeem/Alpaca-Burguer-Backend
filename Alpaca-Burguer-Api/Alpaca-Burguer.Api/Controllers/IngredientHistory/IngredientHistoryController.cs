using Alpaca_Burguer.Application;
using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Api.Controllers
{
    public class IngredientHistoryController : ControllerBase
    {
        private readonly ILogger<IngredientHistoryController> _logger;
        private IRepository<IngredientHistory> _ingredientHistoryRepository { get; set; }
        private IMediator _mediator { get; set; }

        public IngredientHistoryController(ILogger<IngredientHistoryController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("GetAllIngredientHistory")]
        public async Task<ActionResult<IEnumerable<IngredientHistory>>> GetIngredientHistory()
        {
            var request = new GetAllIngredientHistoryRequest();

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }

        [HttpPost("AddIngredientHistory")]
        public async Task<ActionResult<IngredientHistory>> CreateProduct(IngredientHistory ingredientHistory)
        {
            var request = new AddRowIngredientHistoryRequest { IngredientItem = ingredientHistory };

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }
    }
}
