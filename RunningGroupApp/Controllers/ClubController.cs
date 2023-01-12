using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunningGroupApp.Data;
using RunningGroupApp.Interfaces;
using RunningGroupApp.Models;

namespace RunningGroupApp.Controllers
{
    public class ClubController : Controller
    {
       
        private readonly IClubRepository _clubRepository;

        public ClubController(AppDbContext context, IClubRepository clubRepository)
        {
           
            _clubRepository = clubRepository;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<Club> clubs = await _clubRepository.GetAll();
            return View(clubs);
        }
        public async Task <IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetByIdAsync(id);
            return View(club);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Create(Club club)
        {
            if (ModelState.IsValid)
            {
                return View(club);
            }
            _clubRepository.Add(club);
            return RedirectToAction("Index");
        }

        

    }
}
