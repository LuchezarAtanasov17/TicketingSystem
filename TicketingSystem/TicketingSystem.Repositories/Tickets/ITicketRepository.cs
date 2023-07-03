using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Tickets
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetAll();

        Task<Ticket> GetById(Guid id);

        Task Insert(Ticket ticket);

        Task Delete(Guid id);
    }
}
