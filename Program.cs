using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name?");
            var name = Console.ReadLine();

            bool isDefeated = false;

            while (isDefeated == false)
            {
                Console.WriteLine($"Now type something funny, {name}.");

                var joke = Console.ReadLine();

                if (joke == "something funny" || joke == $"something funny, {name}" || joke == $"something funny, {name}.")
                {
                    Console.WriteLine("...I've been defeated.");
                    isDefeated = true;
                }
                else
                {
                    Console.WriteLine("Ha, ha. Very good.");
                }
            }

        }
    }
}
