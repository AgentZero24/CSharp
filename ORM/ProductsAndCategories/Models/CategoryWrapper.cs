using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAndCategories.Models
{
    [NotMapped]
    public class CategoryWrapper
    {
        public Category Category { get; set; }
        public List<Product> AllProductsForCategory { get; set; }
        public int ProductIdToAdd { get; set; }
    }
}
