using FailFast.Application.Domain.Interfaces;
using FailFast.Application.Domain.Models;
using System.Threading.Tasks;

namespace FailFast.Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task Save(User user)
        {
            // Lógica para gravar em base de dados 

            return Task.CompletedTask;
        }
    }
}
