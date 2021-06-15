using FailFast.Application.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailFast.Application.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task Save(User user);
    }
}
