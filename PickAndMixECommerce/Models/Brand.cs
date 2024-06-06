﻿using System.ComponentModel.DataAnnotations;

namespace PickAndMixECommerce.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public List<Sweet> Sweets { get; set; }

    }
}
