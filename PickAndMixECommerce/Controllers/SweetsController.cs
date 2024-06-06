using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Data;
using PickAndMixECommerce.Data.Services;
using PickAndMixECommerce.Models;

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
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("ImageUrl,SweetName,PriceInPence,StockInGrams")] Sweet sweet)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(sweet);
            //}
            _service.Add(sweet);
            return RedirectToAction(nameof(Index));
        }
    }
}
