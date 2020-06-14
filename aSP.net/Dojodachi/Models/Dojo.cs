
namespace Dojodachi.Models
{
    public class Dojo
    {
        public string Name { get; set; }
        public int Happiness { get; set; }
        public int Fullness { get; set; }
        public int Energy { get; set; }
        public int Meal { get; set; }
        public string Message { get; set; }

        public Dojo()
        {
            Name = "Dojodachi";
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meal = 3;
            Message = "Now I have all your energy";
        }
    }
}