using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PickAndMixECommerce.Data.Services;
using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Controllers
{
    public class BasketItemsController : Controller
    {
        private readonly IBasketItemsService _basketItemsService;
        private readonly ISweetsService _sweetsService;

        public BasketItemsController(IBasketItemsService basketItemsService,ISweetsService sweetsService)
        {
            _basketItemsService = basketItemsService;
            _sweetsService = sweetsService;
        }
        public async Task<IActionResult> Index()
        {
            var basketItemsData = await _basketItemsService.GetBasketItemsAsync();
            return View(basketItemsData);
        }
        public  async Task<IActionResult> AddItem(int id)
        {
            var item = await _sweetsService.GetByIdAsync(id);
            if (item != null) {
            
            _basketItemsService.Add(item);
            }
            return RedirectToAction("Index","Sweets");
        }
    }
}
