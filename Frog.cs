using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftProject
{
    internal class Frog : Animal, IWater, ILand
    {
        private const int numberOfLegs = 4;//According to the requirements of the diagram, it was not possible to refer to the fact that a young head has no legs
        private bool isTadpole { get; set; } //Checking whether the frog is a tadpole or already an adult frog, regarding the gills
        public Frog(bool mammals, bool carnivorous, int mood, bool isTadpole) : base(mammals, carnivorous, mood)
        {
            this.isTadpole = isTadpole;
        }
        public override void SayHello(int mood)
        {
            switch (mood)
            {
                case 1:
                    Console.WriteLine("'quack quack quack'");
                    break;
                case 2:
                    Console.WriteLine("The frog will drop into the water");
                    break;
            }
        }
        public bool hasGills()
        {
            if (isTadpole)
                return true;
            return false;
        }
        public bool hasLaysEggs()
        {
            if (isTadpole)
                return false;
            return true;
        }

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
