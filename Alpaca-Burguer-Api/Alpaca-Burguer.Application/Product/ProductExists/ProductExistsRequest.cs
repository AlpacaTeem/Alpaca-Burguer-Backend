using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Application
{
    public class ProductExistsRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
