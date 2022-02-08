// BRONZE
int number = 525;

for(int i = 500, i <= 525; i++);
{
    Console.WriteLine(i);
}
// Printing a loop that goes from 500 - 525


// SILVER
int number = 100;

for(int i = 0; i <= 100; i += 5);
{
    Console.WriteLine(i);
}
// Printing number to 100, with increments of 5

// GOLD
int number = 100;
for(int i = 1, i <= 100; i++);
{
    if (i % 15 == 0) //alt (i % 5 == 0 && i % 3 ==0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else 
    {
        Console.WriteLine(i); 
    }
}
// "Fizz" is divisible by 3
// "Buzz" is divisible by 5
// "FizzBuzz" is divisible by both 3 & 5 (mulitply)