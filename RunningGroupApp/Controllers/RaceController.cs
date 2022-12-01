using Microsoft.AspNetCore.Mvc;

namespace RunningGroupApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
