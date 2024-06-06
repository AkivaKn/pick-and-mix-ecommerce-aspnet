using System.ComponentModel.DataAnnotations;

namespace PickAndMixECommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageURL { get; set; }
        public List<Sweet> Sweets { get; set; }
    }
}
