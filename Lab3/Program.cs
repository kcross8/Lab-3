using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            bool run = true;
                while (run == true)
            {
                Console.WriteLine($"Please Enter a Number Between 1 and 100, {name}: ");
                int i;
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out i))
                {
                    i = int.Parse(input);
                }
                else
                {
                    Console.WriteLine($"{name}, that is not a number, please try again.");
                    
                }

                if (i <= 0)
                {
                    Console.WriteLine($"That is not a valid number, {name}");
                }
                else if (i % 2 == 0 && i <= 25)
                {
                    Console.WriteLine($"{name}, your number is even and less than 25.");
                }
                else if (i % 2 == 0 && i <= 60)
                {
                    Console.WriteLine($"{name}, the number is even.");
                }
                else if (i % 2 == 0 && i <= 100)
                {
                    Console.WriteLine($"{name}, your number is {i} and even.");
                }
                else if (i %2 != 0 && i <= 100)
                {
                    Console.WriteLine($"{name}, your number is {i} and odd.");
                }                
                else
                {
                    Console.WriteLine($"That is not a valid number, {name}");
                }

                bool ask = true;
                while (ask)
                {
                    Console.WriteLine($"Would you like to continue, {name}? (y/n)");
                    string agree = Console.ReadLine();

                    if (agree.ToLower() == "y")
                    {                        
                        ask = false;
                        run = true;
                        continue;
                    }
                    else if (agree.ToLower() == "n")
                    {
                        Console.WriteLine($"The program is now ending officially, goodbye {name}.");
                        ask = false;
                        run = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry {name}, I did not understand that. Please try again.");
                    }
                }
            }
            
        }
    }
}
