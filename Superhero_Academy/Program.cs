using System;
using System.Linq;

namespace Superhero_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Human human = new Human();
            Mage mage = new Mage();
            Mutant mutant = new Mutant();
            Shapeshifter shapeshifter = new Shapeshifter();

            Console.WriteLine("Welcome to Superhero Academy!");

            Console.WriteLine("What is your name?");

            Console.WriteLine("Please tell us your classification");
            Console.WriteLine("1. Human\n2. Mage\n3. Mutant\n4. Shapeshifter");

            int c = 0;

            while(c < 1)
            {
                Console.Write("classification: ");
                string classification = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(classification))
                {
                    Console.WriteLine("Please give a classification");

                    c = 0;
                }
                else if(classification.All(char.IsLetter) || classification.All(char.IsDigit))
                {
                    if (classification.Contains("1") || classification.Contains("human"))
                    {
                        Console.WriteLine("You are a human then, wonderfull, let us see your stats then\n just write your name here");

                        human.Intelligens = generator.Next(0, 10);
                        human.Power = generator.Next(0, 5);
                        human.Stamina = generator.Next(5, 10);
                        human.Strength = generator.Next(2, 8);

                    }
                }
            }

            int n = 0;

            while (n < 1)
            {

            }

            Console.ReadLine();
        }
    }
}
