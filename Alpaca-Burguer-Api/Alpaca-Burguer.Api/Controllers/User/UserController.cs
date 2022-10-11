using Alpaca_Burguer.Application;
using Alpaca_Burguer.Application.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IProductRepository _productRepository { get; set; }
        private IMediator _mediator { get; set; }

        public UserController(ILogger<ProductController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public UserController()
        {
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateProduct(User user)
        {
            var request = new CreateUserRequest { User = user };

            var reponse = await _mediator.Send(request);

            return Ok(reponse);
        }
    }
}
