using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
//using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        //public IActionResult Index()
        //{
        //    return View();
        //}

        private List<Drinks> GetDrinks()
        {
            List<Drinks> Drink = new()
            {
                new Drinks(1,"Fanta","Bright, bubbly and popular, Fanta Orange is a soft drink with a tingly, fruity taste, made with 2 percent juice and contains no artificial colours or flavours.",false,false,true),
                new Drinks(2,"Coca-Cola","The Coca-Cola Company (NYSE: KO) is a total beverage company with products sold in more than 200 countries and territories. Our company's purpose is to refresh the world and make a difference.", false,true,true),
                new Drinks(3,"Sprite","Crisp, refreshing and clean-tasting, Sprite is a lemon and lime-flavoured soft drink. It first hit shop shelves back in 1961 and today it's sold in more than 190 countries. Crisp, refreshing and clean-tasting, Sprite is a lemon and lime-flavoured soft drink.",false,true,true),
                new Drinks(4,"Pepsi","Pepsi is a carbonated soft drink manufactured by PepsiCo. Originally created and developed in 1893 by Caleb Bradham and introduced as Brad's Drink, it was renamed as Pepsi-Cola in 1898, and then shortened to Pepsi in 1961.",false,false,true)
            };
            return Drink;
        }

        private List<HotMeals> GetHotMeals()
        {
            List<HotMeals> HotMeals = new()
            {
                new HotMeals(1,"Minestrone Soup","Minestrone (/ˌmɪnəsˈtroʊni/; Italian: [mineˈstroːne]) is a thick soup of Italian origin made with vegetables, often with the addition of pasta or rice, sometimes both. Common ingredients include beans, onions, celery, carrots, leaf vegetables, stock, parmesan cheese and tomatoes. There is no set recipe for minestrone, since it can usually be made out of whatever vegetables are at one's disposal. It can be vegetarian, contain meat, or contain an animal bone-based stock (such as chicken stock). Food author Angelo Pellegrini claimed that the base of minestrone is bean broth, and that borlotti beans (also called Roman beans) are the beans to use for genuine minestrone.",false),
                new HotMeals(2,"Sweet & Sour Pork","A Chinese stir-fry dish made with juicy pieces of pork tenderloin, bell peppers, onion, and pineapple. Battered pork gets fried until crispy then tossed in a sweet and tangy sauce. So skip the takeout and make a classic Sweet and Sour Pork served with our Easy Fried Rice that the whole family will enjoy.",false),
                new HotMeals(3,"Vegan Birria Tacos Soup","A mixture of shredded oyster mushrooms and jackfruit is simmered in a sauce of dried chiles, spices, and roasted tomatoes, then served in warm corn tortillas.",true)
            };
            return HotMeals;
        }

        private List<FastFoods> GetFastFoods()
        {
            List<FastFoods> FastFoods = new()
            {
                new FastFoods(1,"WAFFLE FRIES","MICAH PETERS: You know the scene in Scott Pilgrim vs. the World where Scott tells Ramona that, were he to have his way, he’d eat garlic bread forever without ever having to stop? I could probably do that with Chick-fil-A waffle fries. Except then I'd get fat. Fries make you fat.",true),
                new FastFoods(2,"FRIES","LINDSAY ZOLADZ: There is a semi-fancy bar that my friends and I like to go to, and we always order a big bowl of their fries because they taste like McDonald’s fries. No matter how fancy the restaurant, “Tastes like McDonald’s fries” is the highest compliment you can give a french fry. Also, no other fast-food item has a Kanye West poem written about it. “I don't trust no food that smells that good, man,” he says of the fries in “McDonald’s Man.” There is no competition; this is the most foolish thing Kanye West has ever said.",true),
                new FastFoods(3,"CHICKEN","K. AUSTIN COLLINS: The only bad thing about Beyoncé is that she has a lifetime of free chicken at Popeyes but, being a vegan, can't take advantage of it. Imagine having unfettered access to that succulent meat and those perfectly crisp and savory flaps of fried skin every day. OK—so some of us are already practically living that life. But imagine living it for free.")
            };
            return FastFoods;
        }
        public string Index()
        {
            return "aa";
        }



        //public ViewResult Index2()
        //{
        //    var Drink = GetDrinks();
        //    var HotMeals = GetHotMeals();
        //    var FastFoods = GetFastFoods();

        //    var menu = new Menu(Drink, HotMeals, FastFoods);
        //    return View(menu);
        //}

        public ViewResult Drinks()
        {
            return View(GetDrinks());
        }

        public ViewResult Menu()
        {
            var Drink = GetDrinks();
            var HotMeals = GetHotMeals();
            var FastFoods = GetFastFoods();

            var menu = new Menus(Drink, HotMeals, FastFoods);
            return View(menu);
        }

    }
}
