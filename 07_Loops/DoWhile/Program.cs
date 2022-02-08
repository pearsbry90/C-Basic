// BONUS Info
// Like a Loop/While, but runs at least one time
// No matter the condition
int iterator = 0;

do
{
    Console.WriteLine("Hello!");
    iterator++;
}
while (iterator < 5);
// Getting 5 "Hello!"'s (0 is technically 1)

do
{
    Console.WriteLine("My conditon is false!");
}
while(false);

while(false)
{
    Console.WriteLine("My condition is false!");
}
// Will automatically stop b/c the list print is not less than 5