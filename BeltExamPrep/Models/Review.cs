using System;
using System.ComponentModel.DataAnnotations;
using BeltExamPrep.Models;

namespace BeltExamPrep.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }

        public string Body { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //Foreign Keys
        public int UserId { get; set; }
        public int FoodTruckId { get; set; }
        //Navigation Props
        public User Author { get; set; }
        public FoodTruck FoodTruck { get; set; }


    }
}