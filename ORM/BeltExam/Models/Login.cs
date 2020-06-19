using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}