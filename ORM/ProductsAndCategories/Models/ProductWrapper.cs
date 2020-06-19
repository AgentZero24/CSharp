
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    [NotMapped]
    public class ProductWrapper
    {
        public Product Product { get; set; }
        public List<Category> AllCategoriesForProduct { get; set; }
        public int CategoryIdToAdd { get; set; }
    }
}