using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the Earth from the sun behind the number?");
            string answer = Console.ReadLine();
            if((answer == "Third" || answer == "third" || answer == "THIRD") && answer !="")
                    { 
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
