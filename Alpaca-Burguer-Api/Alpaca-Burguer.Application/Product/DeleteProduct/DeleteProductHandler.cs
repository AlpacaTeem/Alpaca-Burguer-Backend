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
    public class DeleteProductHandler : IRequestHandler<DeleteProductRequest, Product>
    {
        private IProductRepository _productRepository;

        public DeleteProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.Delete(request.Id);
        }  
    }
}
