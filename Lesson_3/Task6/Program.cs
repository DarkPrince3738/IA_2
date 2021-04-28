using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Write How many legs people has?");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 2)
            {
                count++;
            }

            Console.WriteLine("Write 12*12?");
            answer = int.Parse(Console.ReadLine());
            if (answer == 144)
            {
                count++;
            }

            Console.WriteLine("Write color of sky?");
            string answerS = Console.ReadLine();
            if (answerS == "blue")
            {
                count++;
            }

            switch (count)
            {
                case 3:
                    {
                        Console.WriteLine("Директор");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Учитель");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Лаборант");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
            }
        }
    }
}