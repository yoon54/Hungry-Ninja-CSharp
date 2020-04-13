using System;
using Hungry_Ninjas.Models;

namespace Hungry_Ninjas
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();

            SweetTooth SweetNinja = new SweetTooth();
            SpiceHound SpicyNinja = new SpiceHound();
            while(SweetNinja.IsFull == false)
            {
                SweetNinja.Consume(buffet.Serve());
            }
            Console.WriteLine($"Sweet ninja had total {SweetNinja.ConsumptionHistory.Count} food!");
            while(SpicyNinja.IsFull == false)
            {
                SpicyNinja.Consume(buffet.Serve());
                Console.WriteLine(SpicyNinja.ConsumptionHistory.Count);
            }
            Console.WriteLine($"Spicy ninja had total {SpicyNinja.ConsumptionHistory.Count} food!");
        }
    }
}
