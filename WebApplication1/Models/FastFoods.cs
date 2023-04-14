namespace WebApplication1.Models
{
    public class FastFoods
    {
        public FastFoods(int ıd, string name, string description, bool vegetarian_Food=false)
        {
            Id = ıd;
            Name = name;
            Description = description;
            Vegetarian_Food = vegetarian_Food;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegetarian_Food { get; set; }
    }
}
