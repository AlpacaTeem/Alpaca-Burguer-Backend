using Alpaca_Burguer.Business.Interfaces;
using Alpaca_Burguer.Business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alpaca_Burguer.Application
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, User>
    {
        private readonly IRepository<User> _userRepository;

        public CreateUserHandler(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetAll();
            //Deve ser colocada uma validação para verifica se o email e senha ja existem no sistema

            return _userRepository.Add(request.User);
        }
    }
}
