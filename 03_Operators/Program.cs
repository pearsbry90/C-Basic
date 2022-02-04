using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operations
            int additionResult = 5 + 2;
            Console.WriteLine("5 + 2 = " + additionResult);
            
        // longer version
        // int numOne = 5;
        // int numTwo = 2;
        // int results = numOne + numTwo;

            int subtractionResult = 5 - 2;
            Console.WriteLine(" 5 - 2 = " + subtractionResult);

            int multiplicationResult = 5 * 2;
            Console.WriteLine("5 * 2 = " + multiplicationResult);

        // When adding a decimal/double, make sure to start it as "decimal" and not "int"
            decimal divisionResult = 5m / 2m;
            Console.WriteLine("5 / 2 = " + divisionResult);

        // --Modules/Remainder Operator
            Console.WriteLine(10 % 2);
            Console.WriteLine(10 % 9);
            Console.WriteLine(16 % 3);
            Console.WriteLine(19 % 5);
        }
    }
}
