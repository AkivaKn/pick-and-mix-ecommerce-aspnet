using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickAndMixECommerce.Models
{
    public class Sweet
    {
        [Key]
        public int SweetId { get; set; }
        public string SweetName { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public int PriceInPence { get; set; }
        public string ImageUrl { get; set; }
        public int StockInGrams { get; set; }

    }
}
