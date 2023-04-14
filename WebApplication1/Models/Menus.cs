using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Menus
    {
        public Menus(List<Drinks> drinks, List<HotMeals> hotMeals, List<FastFoods> fastFoods)
        {
            Drinks = drinks;
            HotMeals = hotMeals;
            FastFoods = fastFoods;
        }

        public List<Drinks> Drinks { get; set; }
        public List<HotMeals> HotMeals { get; set; }
        public List<FastFoods> FastFoods { get; set; }
    }
}
