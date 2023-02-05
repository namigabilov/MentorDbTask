using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
