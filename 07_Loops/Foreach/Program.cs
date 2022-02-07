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
    if(letter == '0')
{
    Console.WriteLine('a')
}
    else
    {
        Console.WriteLine(letter)
    }
// Switching out the "o" in Bryon to an "a", printing "Bryan"