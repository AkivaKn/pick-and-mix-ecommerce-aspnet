using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickAndMixECommerce.Models
{
    public class Sweet
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Product Name")]
        [Required(ErrorMessage ="Please provide a name")]
        public string SweetName { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; } 

        [Display(Name = "Product Price in Pence")]
        [Required(ErrorMessage = "Please provide a price")]
        public int PriceInPence { get; set; }
        [Display(Name = "Product Image")]
        [Required(ErrorMessage = "Please provide an image")]
        public string ImageURL { get; set; }
        [Display(Name = "Stock in Grams")]
        [Required(ErrorMessage = "Please provide stock level")]
        public int StockInGrams { get; set; }

    }
}
