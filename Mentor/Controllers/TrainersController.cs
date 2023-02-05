using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class TrainersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
