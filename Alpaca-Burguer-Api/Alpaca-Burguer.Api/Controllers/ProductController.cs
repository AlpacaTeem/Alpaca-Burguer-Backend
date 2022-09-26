using Alpaca_Burguer.Application;
using Alpaca_Burguer.Application.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IProductRepository _productRepository { get; set; }
        private IMediator _mediator { get; set; }

        public ProductController(ILogger<ProductController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("GetProducts")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var request = new GetProductsRequest();

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }

        // GET: api/Products/5
        [HttpGet("GetProduct/{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            var request = new GetProductRequest { Id = id };

            var reponse = await _mediator.Send(request);

            if (Response == null)
            {
                return NotFound();
            }

            return Ok(reponse);
        }

        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            var request = new UpdateProductRequest { Product = product };

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }

        // POST: api/Product
        // https://aka.ms/RazorPagesCRUD.
        [HttpPost("CreateProduct")]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            var request = new CreateProductRequest { Product = product };

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }

        // DELETE: api/Product/5
        [HttpDelete("DeleteProduct/{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(Guid id)
        {

            var request = new DeleteProductRequest { Id = id };

            var reponse = await _mediator.Send(request);

            if (Response == null)
            {
                return NotFound();
            }

            return reponse;
        }

        private async Task<bool> ProductExistsAsync(Guid id)
        {
            var request = new ProductExistsRequest { Id = id };

            var reponse = await _mediator.Send(request);

            return reponse;
        }
    }
}

