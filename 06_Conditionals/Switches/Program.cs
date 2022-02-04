    // Case: indicating a new block of coding to be executed if the value being checked matches the given case
    // Break: indicating the end of a case
    // Default: used to establish code that'll run if no other cast matches the given value
    // Sending the information to another connection (Switch + Case) 
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

// Ex. of a "switch": string name = Console.Readline(); switch (name) -
// Switch statements is to choose from a list of predetermined "cases" based on the input
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


// CHALLENGE
Console.WriteLine("Which friend is my anime bro?");
string friend = Console.ReadLine();

switch (friend)
{
    case "Chris":
        Console.WriteLine("Get him on Dragon Ball Z and their series, and he'll talk for hours!");
        break;
    case "Kendric":
        Console.WriteLine("Just a solid bro to hangout with while watching anime.");
    case "Andrew":
        Console.WriteLine("My anime guru, 'I tell you what'!");
        break;
    case "Stigger":
        Console.WriteLine("Need to get in a debate, my bro will hand it to you.");
        break;
    default:
        Console.WriteLine("Do you even know my Anime Bros?");
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
    

// CHALLENGE (combinging both feelings rating)

int todayRating = int.Parse(feelingRating);
int ratingDifference = todayRating - yesterdayRating;

string output = ratingDifference switch
{
    4 => "Look how bright your day is today; keep fighting strong!",
    3 => "Pat yourself on the back for your growth.",
    2 => "The fight may be there, but you're stronger than you think.",
    1 => "One positive thought is better than none.",
    0 => "Just another day to get through.",
    -1 => "No, take another day off. There's tomorrow.",
    -2 => "Geez. Sorry.",
    -3 => "It's one of those ice cream and drama movies all day, type of day.",
    -4 => "Maybe staying home isn't the best.",
    _ => "Yeah, I'm not a counselor."
};
Console.WriteLine(output);