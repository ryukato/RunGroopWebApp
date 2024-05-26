using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RunGroopWebApp.Data;

namespace RunGroopWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var races = await _context.Races.ToListAsync();
            if (races.IsNullOrEmpty())
            {
                return NotFound();
            }

            return View("index", races);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var race = await _context.Races.Include(model => model.Address)
            .Where(row => row.Id == id)
            .SingleAsync();
            
            if (race == null)
            {
                return NotFound();
            }
            Console.WriteLine(race.Address);
            return View("Details", race);
        }
    }
}