using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Data;
using PickAndMixECommerce.Data.Services;

namespace PickAndMixECommerce.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandsService _service;

        public BrandsController(IBrandsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var brandsData = await _service.GetAll();
            return View(brandsData);
        }
    }
}
