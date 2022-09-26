using Alpaca_Burguer.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application
{
    public class ProductExistsHandler : IRequestHandler<ProductExistsRequest, bool>
    {
        private IProductRepository _productRepository;

        public ProductExistsHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<bool> Handle(ProductExistsRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.Exists(request.Id);
        }
    }
}