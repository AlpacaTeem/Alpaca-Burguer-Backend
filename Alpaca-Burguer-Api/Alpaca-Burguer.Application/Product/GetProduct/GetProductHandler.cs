using Alpaca_Burguer.Application.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application
{
    public class GetProductHandler : IRequestHandler<GetProductRequest, Product>
    {
        private IProductRepository _productRepository;

        public GetProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.Get(request.Id);
        }
    }
}
