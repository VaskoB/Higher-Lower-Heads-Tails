using System;

namespace HigherLowerHeadsTails
{
    class Program
    {
        static void Main(string[] args)
        {
            START:
            Console.WriteLine("Would you like to play Higher/Lower (1) or Heads/Tails (2) ?");
            int choice = int.Parse(Console.ReadLine()); 

            if(choice != 1 && choice != 2)
            {
                Console.WriteLine("Invalid option. Try again.");
                Console.WriteLine();
                goto START;
            }
            else if(choice == 1)
            {
                Console.WriteLine("Pick a starting and ending number");
                Console.Write("Starting number: ");
                int start = int.Parse(Console.ReadLine());
                Console.Write("Ending number: ");
                int end = int.Parse(Console.ReadLine());

                Random rnd = new Random();
                int number = rnd.Next(start, end);

                while(true)
                {
                    Console.WriteLine($"Is your number higher or lower than " + number + "? (Higher/Lower/Correct)");
                    string answer = Console.ReadLine();

                    if(answer == "Higher")
                    {
                        start = number + 1;
                        number = rnd.Next(start, end);
                    }
                    else if(answer == "Lower")
                    {
                        end = number - 1;
                        number = rnd.Next(start, end);
                    }
                    else if(answer == "Correct")
                    {
                        Console.WriteLine("Great! I guessed your number.");
                        Console.WriteLine();
                        break;
                    }
                }
                goto START;
            }
            else if(choice == 2)
            {
                Console.WriteLine("Is it going to be Heads or Tails? (Heads/Tails)");
                string answer = Console.ReadLine();

                Random rnd = new Random();

                int number = rnd.Next(0, 101);

                if(number < 50)
                {
                    Console.WriteLine("It landed on: Heads");
                }
                else 
                {
                    Console.WriteLine("It landed on: Tails");
                }
                Console.WriteLine();

                goto START;
            }
        }
    }
}
