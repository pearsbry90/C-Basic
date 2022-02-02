using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstName);

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("You said your color is " + color);
        }
    }
}
