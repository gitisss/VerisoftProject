using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftProject
{
    internal class Cat : Animal, ILand
    {
        private const int numberOfLegs = 4;
        public Cat(bool mammals, bool carnivorous, int mood) : base(mammals, carnivorous, mood) { }
        public override void SayHello()
        {
            Console.WriteLine("'meow~'");
        }
        public override void SayHello(int mood)
        {
            switch (mood)
            {
                case MOOD_HAPPY:
                    Console.WriteLine("'purr, purr'");
                    break;
                case MOOD_SCARE:
                    Console.WriteLine("'hiss'");
                    break;
                default:
                    Console.WriteLine("You entered an invalid value");
                    break;
            }
        }
        // Implementation of ILand interface
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
