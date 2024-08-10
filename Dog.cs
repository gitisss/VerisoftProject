using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftProject
{
    internal class Dog : Animal, ILand
    {
        private const int numberOfLegs = 4;
        public Dog(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood) { }

        public override void SayHello()
        {
            Console.WriteLine("wagging their tails");
        }
        public override void SayHello(int mood)
        {
            switch (mood)
            {
                case MOOD_HAPPY:
                    Console.WriteLine("The dog will bark Aloud");
                    break;
                case MOOD_SCARE:
                    Console.WriteLine("whooping");
                    break;
                default:
                    Console.WriteLine("You entered an invalid value");
                    break;
            }
        }
        // Implementation of Land interface
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
