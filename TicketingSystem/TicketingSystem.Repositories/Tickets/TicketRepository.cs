using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Data;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Tickets
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<List<Ticket>> GetAll()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetById(Guid id)
        {
            return await _context.Tickets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Ticket ticket)
        {
            await _context.AddAsync(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var ticket = await _context.Tickets.FirstOrDefaultAsync(x => x.Id == id);
            _context.Tickets.Remove(ticket);

            await _context.SaveChangesAsync();
        }
    }
}
