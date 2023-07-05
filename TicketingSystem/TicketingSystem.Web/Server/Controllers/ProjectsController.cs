using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Repositories.Projects;
using TicketingSystem.Web.Shared;

namespace TicketingSystem.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectsController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet]
        public async Task<List<Project>> Get()
        {
            List<Entities.Models.Project> projectEntities = await _projectRepository.GetAll();
            var projects = new List<Project>();

            foreach (var pe in projectEntities)
            {
                Project project= new Project()
                {
                    Id= pe.Id,
                    Name = pe.Name,
                    Description= pe.Description,
                };

                projects.Add(project);
            }

            return projects;
        }
    }
}
