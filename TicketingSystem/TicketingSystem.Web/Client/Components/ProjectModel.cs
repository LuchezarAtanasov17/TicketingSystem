using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Web.Client.Components
{
    public class ProjectModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }
    }
}
