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
    public class GetProductsHandler : IRequestHandler<GetProductsRequest, List<Product>>
    {
        private IProductRepository _productRepository;

        public GetProductsHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Product>> Handle(GetProductsRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.GetAll();
        }
    }
}