using System;

namespace VerisoftProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CatTest();
            DogTest();
            FrogTest();
        }
        public static void CatTest()
        {

            // Create cats with different properties
            Cat happyCat = new Cat(true, true, 1);
            Cat scaredCat = new Cat(true, true, 2);
            Cat neutralCat = new Cat(true, false, 999); // מצב רוח לא תקין

            // Showing greetings from cats]
            Console.WriteLine("Happy Cat says:");
            happyCat.SayHello();
            Console.WriteLine("Scared Cat says:");
            scaredCat.SayHello();
            Console.WriteLine("Neutral Cat says:");
            neutralCat.SayHello();

            // Display greetings with a specific mood
            Console.WriteLine("Happy Cat with MOOD_HAPPY:");
            happyCat.SayHello(1);
            Console.WriteLine("scared Cat with MOOD_SCARE:");
            scaredCat.SayHello(2);
            Console.WriteLine("a Cat with invalid mood:");
            happyCat.SayHello(999); //Invalid mood

            // Display the number of legs of cats
            Console.WriteLine("Number of legs for happyCat: " + happyCat.GetNumberOfLegs());
            Console.WriteLine("Number of legs for scaredCat: " + scaredCat.GetNumberOfLegs());
            Console.WriteLine("Number of legs for neutralCat: " + neutralCat.GetNumberOfLegs());
            Console.WriteLine("----- ----- ----- ----- ----- ----- ----- ----- ------ ------ -----");
        }
        public static void DogTest()
        {
            // Create dogs with different characteristics
            Dog happyDog = new Dog(true, true, 1);
            Dog scaredDog = new Dog(true, true, 2);
            Dog neutralDog = new Dog(true, false, 999); // Invalid mood

            // Show dog greetings
            Console.WriteLine("Happy Dog says:");
            happyDog.SayHello();
            Console.WriteLine("Scared Dog says:");
            scaredDog.SayHello();
            Console.WriteLine("Neutral Dog says:");
            neutralDog.SayHello();

            // Display greetings with a specific mood
            Console.WriteLine("Happy Dog with MOOD_HAPPY:");
            happyDog.SayHello(1);
            Console.WriteLine("Happy Dog with MOOD_SCARE:");
            scaredDog.SayHello(2);
            Console.WriteLine("Happy Dog with invalid mood:");
            happyDog.SayHello(999); // Invalid mood

            // Displaying the number of dogs' legs
            Console.WriteLine("Number of legs for happyDog: " + happyDog.GetNumberOfLegs());
            Console.WriteLine("Number of legs for scaredDog: " + scaredDog.GetNumberOfLegs());
            Console.WriteLine("Number of legs for neutralDog: " + neutralDog.GetNumberOfLegs());
            Console.WriteLine("----- ----- ----- ----- ----- ----- ----- ----- ------ ------ -----");
        }
        public static void FrogTest()
        {
            // Creating frogs with different properties
            Frog tadpoleFrog = new Frog(false, false, 1, true);
            Frog adultFrog = new Frog(false, false, 2, false);

            // Displaying greetings from frogs
            Console.WriteLine("Tadpole Frog with MOOD_HAPPY says:");
            tadpoleFrog.SayHello(1); // mood 1
            Console.WriteLine("adult Frog with MOOD_SCARE says:");
            adultFrog.SayHello(2); // mood 2

            // Tests whether the frog has gills
            Console.WriteLine("Tadpole Frog has gills: " + tadpoleFrog.hasGills());
            Console.WriteLine("adult Frog has gills: " + adultFrog.hasGills());

            // tests whether the frog lays eggs
            Console.WriteLine("Tadpole Frog lays eggs: " + tadpoleFrog.hasLaysEggs());
            Console.WriteLine("adult Frog lays eggs: " + adultFrog.hasLaysEggs());

            // tests whether the frog lays eggs
            Console.WriteLine("Number of legs for tadpoleFrog: " + tadpoleFrog.GetNumberOfLegs());
            Console.WriteLine("Number of legs for adulFrog: " + adultFrog.GetNumberOfLegs());
            Console.WriteLine("----- ----- ----- ----- ----- ----- ----- ----- ------ ------ -----");
        }

    }
}







