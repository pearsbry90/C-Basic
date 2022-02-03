bool isSnowing = false;
bool isGoingOutside = true;
// syntax for an "if" statement is (true/false value)
// {body of code, execute this code if the above statement is true}

if (isSnowing)
{
    Console.WriteLine("It's snowing out!");    
}

// Is snowing AND is going outside
// This runs correctly if these two is true
if (isSnowing && isGoingOutside)
{
    Console.WriteLine("Better wear some snow boots!");
}

// Not snowing OR not going outside
// These can be ran correctly by making them false/optional statements
if (!isSnowing || !isGoingOutside)

Console.WriteLine("I do not need any snow boots!!");

// Exclusively not snowing OR going outside
if(isSnowing ^ isGoingOutside)
{
Console.WriteLine("I will only go outside once the snow stops!!!");
} 

// OTHER OPTIONS
// "else" statements: changing the conditions, but keeping the results
// "else" allows a followup statement to "if" statements that'll only be executed if teh condition isnt' met
if (!isSnowing){
    Console.WriteLine("There is no need to shovel snow!!");
}
// Changing "if" to "else" allows "free range" of an answer to go with the previous "if" statement
else{
    Console.WriteLine("I guess I need to shovel the snow!");
}

// The 1st "if" is a true statemtent (based off of "bool"), it will be read first
// The "!" changes the statement to false

if(isSnowing){
    Console.WriteLine("I guess I have to go clear off my roommates car!!");
}
else if(!isSnowing){
    Console.WriteLine("I don't have to clear off the cars!!");
}
else{
    Console.WriteLine("I don't even know what we are talking about!!");
}


// CHALLENGE
bool isBornWithSuperPowers = true;
bool isGoingToBeASuperHero = true;

if (isBornWithSuperPowers)
{
    Console.WriteLine("Following in your parents footsteps.");
}

if (!isBornWithSuperPowers!)
{
    Console.WriteLine("You are still a beautiful baby.");
}

if (isBornWithSuperPowers || isGoingToBeASuperHero)
{
    Console.WriteLine("You already have your career built and planned out for you.");
}

if (isBornWithSuperPowers ^ isGoingToBeASuperHero);
{
    Console.WriteLine("You will still live and enjoy your life.");
}