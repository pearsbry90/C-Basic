// A for loop is used for saying "do this for a certain amount of time"
// Ex. If you have 5 cookies and you're eating one at a time until they're gone, you're going to eat a cookie for a set amount of iterations which in this case is 5.

// Create initial target
int number = 100;

// for (initializer; condition iterator) {body}
// 1     //2         //3        //4
for (int i = 0; i < number; i++)
{
    Console.WriteLine(i)
}

// 1 - for Keyword
// 2 - Declaration and initilization of iterator
// 3 - Boolean expression for the loop
// 4 - Increment the iterator at the END of each loop
// 5 - Body of the loop, runs iteration if the boolean is true  