using System;

namespace Roll_2_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            Console.WriteLine("Hi! I'll roll 2 die for you and tell you how many tries it took to roll 2 of a kind. Press ENTER to continue.");
            Console.ReadKey();

            int roll1 = 0;
            int roll2 = -1;
            int attempts = 0;

            while (roll1 != roll2) {
                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine(roll1 + ", " + roll2);
                Console.ReadKey();
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll 2 of a kind.");

            Console.ReadKey();
        }
    }
}