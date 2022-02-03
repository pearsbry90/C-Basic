    // Case: indicating a new block of coding to be executed if the value being checked matches the given case
    // Break: indicating the end of a case
    // Default: used to establish code that'll run if no other cast matches the given value
    // Sending the information to another connection 
Console.WriteLine("Please give us your name!");


string name = Console.ReadLine();
string greeting = name switch 
{
    "Ryo" => "Hello Bro",
    _ => "Who are you?"
};
Console.WriteLine(greeting);

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
        break;
    // This is ONLY used if none of the other cases are matches
    default:
        Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}      


Console.WriteLine("How were you feeling yesterday on a scale of 1-5?");
string ratingInput = Console.ReadLine();
// Parse takes a string and "verifies" that it's a number
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch 
{
    1 => "Dang. Maybe today will be a better",
    2 => "Oh, sorry to hear that",
    3 => "Nice, sounds like a good day",
    4 => "Good stuff",
    5 => "That's wonderful to hear",
    _ => "Man, you are off the charts!"
};
Console.WriteLine(response);
    

