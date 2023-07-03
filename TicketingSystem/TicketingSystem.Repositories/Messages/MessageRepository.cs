using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Data;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Messages
{
    public class MessageRepository : IMessageRepository
    {
        private readonly ApplicationDbContext _context;

        public MessageRepository()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<List<Message>> GetAll()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task<Message> GetById(Guid id)
        {
            return await _context.Messages.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var message = await _context.Messages.FirstOrDefaultAsync(x => x.Id == id);
            _context.Messages.Remove(message);

            await _context.SaveChangesAsync();
        }
    }
}
