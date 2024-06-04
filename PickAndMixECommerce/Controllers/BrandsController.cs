using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Data;

namespace PickAndMixECommerce.Controllers
{
    public class BrandsController : Controller
    {
        private readonly AppDbContext _context;

        public BrandsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var brandsData = await _context.Brands.ToListAsync();
            return View(brandsData);
        }
    }
}
