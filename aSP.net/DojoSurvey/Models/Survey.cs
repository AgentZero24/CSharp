namespace DojoSurvey.Models
{
    public class Survey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public string email { get; set; }

        public string password { get; set; }

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

