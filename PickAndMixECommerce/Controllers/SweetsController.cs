using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Data;
using PickAndMixECommerce.Data.Services;

namespace PickAndMixECommerce.Controllers
{
    public class SweetsController : Controller
    {
        private readonly ISweetsService _service;

        public SweetsController(ISweetsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var sweetsData = await _service.GetAll();
            return View(sweetsData);
        }
    }
}
