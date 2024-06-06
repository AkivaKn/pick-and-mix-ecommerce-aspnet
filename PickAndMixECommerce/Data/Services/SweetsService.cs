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

        public async Task<IEnumerable<Sweet>> GetAllAsync(string sortOrder, string searchString)
        {
            var sweets = from s in _context.Sweets
                         select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                sweets = sweets.Where(s => s.SweetName.Contains(searchString)
                                       || s.Brand.BrandName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    sweets = sweets.OrderByDescending(s => s.SweetName);
                    break;
                case "price":
                    sweets = sweets.OrderBy(s => s.PriceInPence);
                    break;
                case "price_asc":
                    sweets = sweets.OrderByDescending(s => s.PriceInPence);
                    break;
                default:
                    sweets = sweets.OrderBy(s => s.SweetName);
                    break;
            }
            var result = await sweets.Include(b => b.Brand).AsNoTracking().ToListAsync();
            return result;
        }

        public async Task<Sweet> GetByIdAsync(int id)
        { 
            var result = await _context.Sweets.Include(b => b.Brand).AsNoTracking().FirstOrDefaultAsync(n => n.Id == id); 
            return result;
        }

        public Sweet Update(int id, Sweet newSweet)
        {
            throw new NotImplementedException();
        }
    }
}
