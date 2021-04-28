using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many apples do you have after eating 1, at the start you had 6");
            Console.WriteLine("Write your answer");
            int value = int.Parse(Console.ReadLine());
            if (value == 5)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Think better");
            }
        }
    }
}
