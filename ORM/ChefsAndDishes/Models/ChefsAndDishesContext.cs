using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChefsAndDishes.Models
{
    public class ChefsAndDishesContext : DbContext
    {
        public ChefsAndDishesContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Chef> Chefs { get; set; }
    }
}