using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User> GetById(Guid id);

        Task Insert(User user);

        Task Delete(Guid id);
    }
}
