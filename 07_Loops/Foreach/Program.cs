// A collection (list of items)
// An Array is a data structure that can hold multiple items of the same type

string instructorName = "Bryon";
string [] instructors = new string [] {"Adam", "Kate", instructorName};
// <List string>

// foreach(declaredIterator in enumerableCollection) {body}

foreach(string name in instructors)
{
    Console.WriteLine($"Hello {name}");
}
// The list will continue until it is complete fulfilling the list

foreach(char letter in instructorName)
{
    Console.WriteLine(letter);
}
// Being able to print off the letters of the names

foreach(char letter in instructorName)
    if(letter == 'o')
{
    Console.WriteLine('a');
}
    else
    {
        Console.WriteLine(letter);
    }
// Switching out the "o" in Bryon to an "a", printing "Bryan" after the "Hello's ..."

// EXERCISE
string ninjaNames = "Mutant Ninja Turtles";
string [] ninja = new string [] {"Leo, Ralph, Donni, Mikey", ninjaNames};

foreach(string name in ninja)
{
    Console.WriteLine($"Who wants pizza {ninjaNames}?");
}

int [] number = new int [] {1, 5, 10, -4, -12, 0};

foreach(int number in number)
{
    if (number > 0)
    {
        Console.WriteLine($"{number} is a positive number.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{number} is a negative number.");
    }
    else 
    {
        Console.WriteLine($"{number} is a neutral number.");
    }
}