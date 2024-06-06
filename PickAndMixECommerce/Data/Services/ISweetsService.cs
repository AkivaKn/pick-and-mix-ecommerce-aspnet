using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public interface ISweetsService
    {
        Task<IEnumerable<Sweet>> GetAllAsync(string sortOrder,string searchString);
        Task<Sweet> GetByIdAsync(int id);
        void Add(Sweet sweet);
        Sweet Update(int id, Sweet newSweet);
        void Delete(int id);

    }
}
