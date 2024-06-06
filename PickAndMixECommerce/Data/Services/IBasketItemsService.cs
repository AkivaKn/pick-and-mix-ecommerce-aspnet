using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public interface IBasketItemsService
    {
        Task<IEnumerable<BasketItem>> GetBasketItemsAsync();
        void Add(Sweet sweet);
        void Delete(int itemId);
        void EmptyBasket(int shoppingBasketId);
        int GetBasketCount(int shoppingBasketId);
        int GetTotal(int shoppingBasketId);

    }
}
