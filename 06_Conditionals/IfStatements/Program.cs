bool isSnowing = false;
bool isGoingOutside = true;

if(isSnowing)
{
Console.WriteLine("It is snowing out!");    
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

if(isSnowing ^ isGoingOutside)
{
Console.WriteLine("I will only go outside once the snow stops!!!");
} 


if(!isSnowing){
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