using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickAndMixECommerce.Models
{
    public class BasketItem
    {
        public int Id { get; set; }

        public int SweetId { get; set; }
        [ForeignKey("SweetId")]
        public Sweet Sweet { get; set; }
        [ValidateNever]
        public int Count { get; set; } = 1;
        [ValidateNever]
        public System.DateTime DateCreated { get; set; }
    }
}
