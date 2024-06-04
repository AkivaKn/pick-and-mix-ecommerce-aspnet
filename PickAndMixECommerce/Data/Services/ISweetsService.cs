using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public interface ISweetsService
    {
        Task<IEnumerable<Sweet>> GetAll();
        Sweet GetById(int id);
        void Add(Sweet sweet);
        Sweet Update(int id, Sweet newSweet);
        void Delete(int id);

    }
}
