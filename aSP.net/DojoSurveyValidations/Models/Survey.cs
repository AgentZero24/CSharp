using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidations.Models
{
    public class Survey
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Language { get; set; }
        [MaxLength(40)]
        public string Comment { get; set; }

        public Survey() { }
        public Survey(string name, string location, string language, string comment)
        {
            Name = name;
            Location = location;
            Language = language;
            Comment = comment;
        }

    }
}