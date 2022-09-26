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
    public class UpdateProductHandler : IRequestHandler<UpdateProductRequest, Product>
    {
        private IProductRepository _productRepository;

        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.Update(request.Product);
        }
    }
}