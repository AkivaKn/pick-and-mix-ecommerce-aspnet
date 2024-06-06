using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public class BasketItemsService : IBasketItemsService
    {
        private readonly AppDbContext _context;

        public BasketItemsService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Sweet sweet)
        {
            var basketItem = new BasketItem
            {
                SweetId = sweet.Id,
            };
            _context.BasketItems.Add(basketItem);
            _context.SaveChanges();
        }

        public void Delete(int itemId)
        {
            throw new NotImplementedException();
        }

        public void EmptyBasket(int shoppingBasketId)
        {
            throw new NotImplementedException();
        }

        public int GetBasketCount(int shoppingBasketId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BasketItem>> GetBasketItemsAsync()
        {
            var result = await _context.BasketItems.Include(b => b.Sweet).ThenInclude(b => b.Brand).AsNoTracking().ToListAsync();
            return result;
        }

        public int GetTotal(int shoppingBasketId)
        {
            throw new NotImplementedException();
        }
    }
}
