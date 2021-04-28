using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess which number");
            string res = Console.ReadLine();
            //    string answer = (res == "7") ? "Correct" : "Try Again";
            //    Console.WriteLine(answer); 
            string answer;
            if (res == "7")
            {
                answer = "Correct"; 
            }
            else
            {
                answer = "Try Again";
            }
            Console.WriteLine(answer);
        }
    }
}
