    // Case: indicating a new block of coding to be executed if teh value being checked matches the given case
    // Break: indicating the end of a case
    // Default: used to establish code that'll run if no other cast matches the given value
    // Sending the information to another connection 
Console.WriteLine("Please give us your name!");
string name = Console.ReadLine();
switch (name)
{
    case "Ryo":
    Console.WriteLine("Nice to meet you " + name);
    break;
    default:
    break;
}

Console.WriteLine("How are you feeling today on a scale 1-5?");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5":
        Console.WriteLine("That's great to hear!");
        break;
    case "4":
        Console.WriteLine("Good Stuff");
        break;
    case "3":
        Console.WriteLine("Hope things improve!");
        break;    
    case "2":  
        Console.WriteLine("Oh. Sorry to hear that!");
        break;
    case "1":
        Console.WriteLine("Dang. We hope your day get better!");
    // This is ONLY used if none of the other cases are matches
    default:
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}      
    