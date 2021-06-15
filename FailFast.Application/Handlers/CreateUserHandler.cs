using FailFast.Application.Commands;
using FailFast.Application.Core;
using FailFast.Application.Domain.Interfaces;
using FailFast.Application.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FailFast.Application.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUser, Response>
    {
        private readonly IUserRepository _repository;

        public CreateUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            var user = new User(request.Name, request.Email, request.Password);

            await _repository.Save(user);

            return new Response("Usuário criado com sucesso");
        }
    }
}
