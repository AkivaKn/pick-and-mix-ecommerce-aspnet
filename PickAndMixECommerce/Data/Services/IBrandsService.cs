using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public interface IBrandsService
    {
        Task<IEnumerable<Brand>> GetAll();
        Brand GetById(int id);
        void Add(Brand brand);
        Brand Update(int id, Brand newBrand);
        void Delete(int id);
    }
}
