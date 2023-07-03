using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Messages
{
    public interface IMessageRepository
    {
        Task<List<Message>> GetAll();

        Task<Message> GetById(Guid id);

        Task Insert(Message message);

        Task Delete(Guid id);
    }
}
