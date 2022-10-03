using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Business.Models
{
    public class EntityBase 
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }
    }
}
