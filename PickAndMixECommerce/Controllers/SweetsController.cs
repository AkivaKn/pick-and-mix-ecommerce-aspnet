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
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var sweetsData = await _service.GetAllAsync(sortOrder, searchString);
            return View(sweetsData);
        }
        public async Task<IActionResult> Details(int id)
        {
            var sweetDetails = await _service.GetByIdAsync(id);
            if(sweetDetails == null) { return View("NotFound"); }
            return View(sweetDetails);
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
