using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
        //-- Composite Formatting 
            string first = "The cars we sell are";
            string second = "BMW, Lexus, Mercedes and Lucid Air";

            string concatenatedResult = first + " " + second;

            Console.WriteLine(concatenatedResult);
            
            string firstName = "Chris";
            string lastName = "Mack";
            
            string compositeResults = string.Format("His name is {0} {1}", firstName, lastName);

            Console.WriteLine(compositeResults);
            // Another way to format the above method
            Console.WriteLine("His name is {0} {1}", firstName, lastName);

            string interpolationResult = $"His name is still {firstName} {lastName}!";
            Console.WriteLine(interpolationResult); 
            Console.WriteLine($"His name is still {firstName} {lastName}!");
        }
    }
}
