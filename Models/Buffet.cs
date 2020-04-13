using System;
using System.Collections.Generic;


namespace Hungry_Ninjas.Models
{
    class Buffet
{
        public List<IConsumable> Menu;
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Beef", 400, false, false),
                new Food("Chicken", 300, false, false),
                new Food("Steak", 500, false, false),
                new Food("Tomatoes", 30, false, false),
                new Food("Peppers", 400, true, false),
                new Food("Apples", 400, false, true),
                new Food("Oranges", 400, false, true),
                new Drink ("Mountain Doo", 200, false, false),
                new Drink ("Baja Blast", 400, false, true),
                new Drink ("Orange Juice", 400, false, true),
                new Drink ("Coffee", 200, false, false),
                new Drink ("Strawberry Smoothie", 400, false, true),
                new Drink ("Orange Juice", 400, false, true),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            IConsumable item = Menu[rand.Next(Menu.Count)];
            Console.WriteLine($"Oh that {item.Name} is so tasty!!!");
            return item;
            
        }
}
}
