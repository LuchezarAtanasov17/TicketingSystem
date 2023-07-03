using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Projects
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAll();

        Task<Project> GetById(Guid id);

        Task Insert(Project project);

        Task Delete(Guid id);
    }
}
