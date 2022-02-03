﻿// Using Write instead of WriteLine
// Ternary is composed of 3 parts
Console.Write("Enter your age:");
string response = System.Console.ReadLine();
// Parse helps put itself in a number teaming up with "int"
int age = int.Parse(response);

// For the age, this is a true/false statement - ":"
string output = age >= 18 ? "You can vote!" : "You're too young to vote.";

Console.WriteLine(output);