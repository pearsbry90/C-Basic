// A for loop is used for saying "do this for a certain amount of time"
// Ex. If you have 5 cookies and you're eating one at a time until they're gone, you're going to eat a cookie for a set amount of iterations which in this case is 5.

// Create initial target number
int number = 100;

// for (initializer; condition iterator) {body}
// 1     //2         //3        //4
for (int i = 0; i < number; i++)
// i++ is saying i + number
{
    Console.WriteLine(i)
}

// 1 - for Keyword
// 2 - Declaration and initilization of iterator
// 3 - Boolean expression for the loop
// 4 - Increment the iterator at the END of each loop
// 5 - Body of the loop, runs iteration if the boolean is true  

// EXERCISE
int number = 45;

for (int i = 0; i < number; i++)
{
    Console.WriteLine(i);
}
// Number will go from 0 - 44, and loops it

int number = 100;

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("What number do you want me to count to?");
string userInput = Console.ReadLine();

int target = int.Parse(userInput);

for (int i = 0; i <= target, i++)
{   
    Console.WriteLine(i);
}
// Prompting the user for a number to count to/from "0"
