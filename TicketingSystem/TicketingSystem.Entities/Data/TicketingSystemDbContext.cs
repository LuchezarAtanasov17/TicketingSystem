using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Entities.Data
{
    public class TicketingSystemDbContext : IdentityDbContext<User, Role, Guid>
    {
        public TicketingSystemDbContext(DbContextOptions options) : base(options)
        {
        }

        protected TicketingSystemDbContext()
        {
        }

        public DbSet<Message> Messages { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
