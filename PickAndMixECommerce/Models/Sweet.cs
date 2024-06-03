using System.ComponentModel.DataAnnotations;

namespace PickAndMixECommerce.Models
{
    public class Sweet
    {
        [Key]
        public int SweetId { get; set; }
        public string SweetName { get; set; }
        public string BrandtName { get; set; }
        public int PriceInPence { get; set; }
        public string ImageUrl { get; set; }
        public int StockInGrams { get; set; }

    }
}
