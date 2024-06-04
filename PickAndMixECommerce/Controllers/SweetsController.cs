using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Data;

namespace PickAndMixECommerce.Controllers
{
    public class SweetsController : Controller
    {
        private readonly AppDbContext _context;

        public SweetsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sweetsData = await _context.Sweets.ToListAsync();
            return View(sweetsData);
        }
    }
}
