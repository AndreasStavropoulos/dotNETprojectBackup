namespace FirstProject
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }
        public int YearOfProduction { get; set; }

        private static int startingIdnumber = 1;

        public Movie()
        {
        }

        public Movie(string name, string genre, decimal price, int duration, int yearOfProduction)
        {
            Name = name;
            Genre = genre;
            Price = price;
            Duration = duration;
            YearOfProduction = yearOfProduction;
            Id = startingIdnumber;
            startingIdnumber++;
        }

        public Movie(int id, string name, string genre, decimal price, int duration, int yearOfProduction)
        {
            Name = name;
            Genre = genre;
            Price = price;
            Duration = duration;
            YearOfProduction = yearOfProduction;
            Id = id;
        }
    }
}