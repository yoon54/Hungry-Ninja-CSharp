using System;
using System.Collections.Generic;

namespace Hungry_Ninjas.Models
{
    public class Ninja
    {
        private int calorieIntake;
        public Ninja()
        {
            calorieIntake = 0;
        }
        public bool isFull
        {
            get{
                return calorieIntake > 1200;
            }
        }
        public void Eat(Food item){
            if( isFull == true)
            {
                Console.WriteLine($"This Ninja is too full to eat");
            }
            else{
                Console.WriteLine($"This Ninja just ate {item.Name}");
                calorieIntake += item.Calories;
            }
            
            
        }
        public void ShowStats()
        {
            Console.WriteLine($"Calories consumed = {calorieIntake}, is Full? : {isFull}");
        }
    }
}