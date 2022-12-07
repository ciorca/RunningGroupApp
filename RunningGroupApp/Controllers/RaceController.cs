using Microsoft.AspNetCore.Mvc;
using RunningGroupApp.Data;
using RunningGroupApp.Models;

namespace RunningGroupApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly AppDbContext _context;

        public RaceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }
    }
}
