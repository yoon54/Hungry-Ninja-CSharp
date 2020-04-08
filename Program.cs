using System;
using Hungry_Ninjas.Models;

namespace Hungry_Ninjas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja James = new Ninja();
            Buffet AllYouCanEat = new Buffet();
            var food = AllYouCanEat.Serve();
            James.Eat(food);
             var food1 = AllYouCanEat.Serve();
            James.Eat(food1);
             var food2 = AllYouCanEat.Serve();
            James.Eat(food2);
             var food3 = AllYouCanEat.Serve();
            James.Eat(food3);
            James.ShowStats();
        }
    }
}
