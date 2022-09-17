using Alpaca_Burguer.Business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Application
{
    public class CreateProductRequest : IRequest<Product>
    {
        public Product Product { get; set; }
    }
}
