using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsAndDishes.Models
{
    public class Dish
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int DishId { get; set; }

        [Required(ErrorMessage = "is required")]
        [MinLength(2, ErrorMessage = "must be at least 2 characters")]
        [Display(Name = "Name Of Dish")]
        public string NameOfDish { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "# of Calories")]
        public int NumberOfCalories { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required")]
        [Display(Name = "Tastiness")]
        public string Tastiness { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Chef")]
        public int ChefId { get; set; }
        public Chef Creator { get; set; }

    }
}
