// Using Write instead of WriteLine
// Ternary is composed of 3 parts
Console.Write("Enter your age:");
string response = System.Console.ReadLine();
// Parse helps put itself in a number teaming up with "int"
int age = int.Parse(response);

// For the age, this is a true/false statement - ":"
string output = age >= 18 ? "You can vote!" : "You're too young to vote.";

Console.WriteLine(output);


// CHALLENGE <written with an if else statement>
if (age >= 18)
{
    Console.WriteLine("I'm not sure whom to vote for.");
}

else{
    Console.WriteLine("Gotta wait until your 18.");
}
Console.WriteLine(output);