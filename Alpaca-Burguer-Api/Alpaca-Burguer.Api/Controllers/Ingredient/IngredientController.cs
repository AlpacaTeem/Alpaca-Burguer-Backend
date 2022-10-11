using Alpaca_Burguer.Application;
using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Api.Controllers
{
    public class IngredientController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IIngredientRepository _ingredientRepository { get; set; }
        private IMediator _mediator { get; set; }

        public IngredientController(ILogger<ProductController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("GetIngredients")]
        public async Task<ActionResult<IEnumerable<Ingredient>>> GetProducts()
        {
            var request = new GetProductsRequest();

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }

        // GET: api/Products/5
        [HttpGet("GetIngredient/{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(Guid id)
        {
            var request = new GetIngredientRequest { Id = id };

            var reponse = await _mediator.Send(request);

            if (Response == null)
            {
                return NotFound();
            }

            return Ok(reponse);
        }

        // POST: api/Product
        // https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreateIngredient")]
        public async Task<ActionResult<Ingredient>> CreateProduct(Ingredient ingredient)
        {
            var request = new CreateIngredientRequest { Ingredient = ingredient };

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }

        // DELETE: api/Product/5
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(Guid id)
        {

            var request = new DeleteIngredientRequest { Id = id };

            var reponse = await _mediator.Send(request);

            if (Response == null)
            {
                return NotFound();
            }

            return Ok(reponse);
        }

        [HttpPut("UpdateIngredient")]
        public async Task<IActionResult> UpdateIngredient(Ingredient ingredient)
        {
            var request = new UpdateIngredientRequest { Ingredient = ingredient };

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }
    }
}
