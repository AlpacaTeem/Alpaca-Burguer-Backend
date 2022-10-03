using System;
using System.Collections.Generic;
using System.Text;

namespace Alpaca_Burguer.Business.Models
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid Password { get; set; }
        public string Role { get; set; }

        public User(string name, string email, Guid password, string role)
        {
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
