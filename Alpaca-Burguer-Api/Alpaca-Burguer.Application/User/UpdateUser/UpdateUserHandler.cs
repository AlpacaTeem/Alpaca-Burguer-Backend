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
    public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, User>
    {
        private readonly IRepository<User> _userRepository;

        public UpdateUserHandler(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var userToUpdate = await _userRepository.Get(request.User.Id);
            //Deve ser colocada uma validação para verifica se o email e senha ja existem no sistema
            
            return await _userRepository.Update(userToUpdate);
        }
    }
}
