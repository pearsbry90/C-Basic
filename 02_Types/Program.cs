using System;

namespace BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
/* bool is a true false value, no quotes around the word */ 
// this is b/c true and false are keywords, not strings
bool isLoggedIn = true; 
Console.WriteLine(isLoggedIn);

// integers, or int, are whole numbers only
int age = 42;
Console.WriteLine(age);

double balanceDue = 800.99d;
Console.WriteLine(balanceDue);

// decimal has a lot of possible decimal points
// it also needs the m suffix to know it's a decimal type
decimal accountBalance = 9000.01m;
Console.WriteLine(accountBalance);

// another useage of decimal; memory usages; giving a range of a number
float averageHeight = 5.7f;
Console.WriteLine(averageHeight);

// Notice that when the accountBalance gets written to the console there is no m suffix in the output
        } 
    }
}
