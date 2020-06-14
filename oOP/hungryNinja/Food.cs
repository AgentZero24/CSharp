namespace hungryNinja
{
 class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 

        public sustenance(string name, int calories, int isspicy, int issweet)
        {

            Name = name;
            Calories = calories;
            IsSpicy = isspicy;
            IsSweet = issweet;


        }// add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
    }
}
