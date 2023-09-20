using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.View
{
    internal class View
    {
        public void ChickenGUI(bool canFly, bool fourLegs, bool isMale, bool hasFeathers, bool hasFur, bool Mammal, bool layEggs, string name)
        {
            Console.WriteLine($"Fly: {canFly}\n" +
                $"Four Legs: {fourLegs}\n" +
                $"Male: {isMale}\n" +
                $"Feathers: {hasFeathers}\n" +
                $"Fur: {hasFur}\n" +
                $"Mammal: {Mammal}\n" +
                $"Lay eggs: {layEggs}\n" +
                $"Name: {name}");
        }

        public void Read()
        {
            Console.ReadLine();
        }

        public void Line()
        {
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
