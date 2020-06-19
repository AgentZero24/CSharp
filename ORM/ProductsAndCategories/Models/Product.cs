using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int ProductId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = " Name")]
        public string ProductName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; } = 0;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Link> Categories { get; set; }


    }
}