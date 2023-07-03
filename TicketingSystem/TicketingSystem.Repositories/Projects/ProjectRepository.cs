using System.Data.Entity;
using TicketingSystem.Entities.Data;
using TicketingSystem.Entities.Models;

namespace TicketingSystem.Repositories.Projects
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<List<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetById(Guid id)
        {
            return await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x => x.Id == id);
            _context.Projects.Remove(project);

            await _context.SaveChangesAsync();
        }
    }
}
