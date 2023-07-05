using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
