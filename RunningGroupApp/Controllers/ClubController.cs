using Microsoft.AspNetCore.Mvc;

namespace RunningGroupApp.Controllers
{
    public class ClubController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
