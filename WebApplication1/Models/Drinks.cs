namespace WebApplication1.Models
{
    public class Drinks
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Alcohol { get; set; }
        public bool Fruity { get; set; }
        public bool Fizzy { get; set; }
        public Drinks(int id, string name, string description, bool alcohol=false, bool fruity=false, bool fizzy =false)
        {
            Id = id;
            Name = name;
            Description = description;
            Alcohol = alcohol;
            Fruity = fruity;
            Fizzy = fizzy;
        }
        
    }
}
