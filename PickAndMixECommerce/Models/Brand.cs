using System.ComponentModel.DataAnnotations;

namespace PickAndMixECommerce.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
