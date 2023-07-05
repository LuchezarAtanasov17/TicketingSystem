using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Web.Shared
{
    public class Ticket
    {
        public Guid Id { get; set; }

        public Guid SenderId { get; set; }

        public Guid ProjectId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public string Type { get; set; }

        public string State { get; set; }

        public User Sender { get; set; }

        public Project Project { get; set; }

        public byte[]? Files { get; set; }

        public ICollection<Message> Messages { get; set; } = new HashSet<Message>();
    }
}
