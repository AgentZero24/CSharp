using System.Collections.Generic;
using ChefsAndDishes.Models;
using System;

namespace ChefsAndDishes.Models
{
    public class Wrapper
    {
        public Dish Dish { get; set; }
        public List<Chef> AllChefs { get; set; }
    }
}