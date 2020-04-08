using System;
using System.Collections.Generic;


namespace Hungry_Ninjas.Models
{
    class Buffet
{
        public List<Food> Menu = new List<Food>();
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Beef", 400, false, false),
                new Food("Chicken", 300, false, false),
                new Food("Steak", 500, false, false),
                new Food("Tomatoes", 30, false, false),
                new Food("Peppers", 400, true, false),
                new Food("Apples", 400, false, true),
                new Food("Oranges", 400, false, true)
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            Food lunch = Menu[rand.Next(Menu.Count)];
            Console.WriteLine($"Oh that {lunch.Name} is so tasty!!!");
            return lunch;
            
        }
}
}
