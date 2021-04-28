using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your word");
            string word = Console.ReadLine();
            switch (word)
            {
                case "apple":
                    {
                        Console.WriteLine("Яблуко");
                        break;
                    }
                case "pineapple":
                    {
                        Console.WriteLine("Груша");
                        break;
                    }
                case "orange":
                    {
                        Console.WriteLine("Апельсин");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect word");
                        break;
                    }

            }      
        }
    }
}
