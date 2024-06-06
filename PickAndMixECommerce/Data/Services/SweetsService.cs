using Microsoft.EntityFrameworkCore;
using PickAndMixECommerce.Models;

namespace PickAndMixECommerce.Data.Services
{
    public class SweetsService : ISweetsService
    {
        private readonly AppDbContext _context;

        public SweetsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Sweet sweet)
        {
            _context.Sweets.Add(sweet);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Sweet>> GetAll()
        {
            var result = await _context.Sweets.Include(b => b.Brand).AsNoTracking().ToListAsync();
            return result;
        }

        public Sweet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Sweet Update(int id, Sweet newSweet)
        {
            throw new NotImplementedException();
        }
    }
}
