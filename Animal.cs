using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerisoftProject
{
    abstract class Animal
    {
        protected readonly bool mammals;
        protected readonly bool carnivorous;
        public const int MOOD_HAPPY = 1;
        public const int MOOD_SCARE = 2;
        protected int mood { get; set; }
        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            this.mood = mood;
        }

        public virtual void SayHello() { }
        public abstract void SayHello(int mood);
        public bool IsMammals()
        {
            return mammals;
        }
        public void setMammals(bool mammal) { }
        public bool IsCarnivorous()
        {
            return carnivorous;
        }
        public void setCarnivorous(bool carnivorous)
        {
            /*
             this.carnivorous = carnivorous;
             It is not possible to edit a readonly variable, I saw no need to implement this function
            */
        }
    }

}
