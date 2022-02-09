// WhileWhile loops execute a statement or a block of statements while the specified boolean expression evaluates to TRUE
// Meaning, giving the while loop a boolean to evaluate: TRUE loops; FALSE does not
// Ex. If you're hungry, you should eat. If you're not hungry, you should stop eating.

// Delcare a variable
int number = 0;

// Keyword Condition
while (number <= 100) 
{
    // Loop
    // Print the number and add 5
    Console.WriteLine(number);
    number = number + 5;
}

// Infinite Loop
while (number <= 100)
{ 
Console.WriteLine(number);
number = number = 5;
}