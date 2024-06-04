using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public class BrandsService : IBrandsService
    {
        private readonly AppDbContext _context;

        public BrandsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Brand>> GetAll()
        {
            var result = await _context.Brands.ToListAsync();
            return result;
        }

        public Brand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Brand Update(int id, Brand newBrand)
        {
            throw new NotImplementedException();
        }
    }
}
