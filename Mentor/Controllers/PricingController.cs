using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
