using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of product");
            int numberOfBuying = int.Parse(Console.ReadLine());
            switch (numberOfBuying)
            {
                case 1:
                    {
                        Console.WriteLine("Назва товару - телефон, ціна 300$");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Назва товару - навушники, ціна 100$");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Назва товару - планшет, ціна 400$");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Назва товару - ручка, ціна 10$");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Назва товару - клавіатура, ціна 150$");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого товару не існує");
                        break;
                    }
            }
        }
    }
}