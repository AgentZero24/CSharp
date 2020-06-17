using System;
using System.ComponentModel.DataAnnotations;
using BeltExamPrep.Models;

namespace BeltExamPrep.Models
{
    public class FoodTruck
    {
        [Key]
        public int FoodTruckId { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        [MinLength(3)]
        public string Style { get; set; }
        [MinLength(10)]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        //Foreign Keys
        public int UserId { get; set; }

        //Navigation Props
        public User UploadedBy { get; set; }

    }
}