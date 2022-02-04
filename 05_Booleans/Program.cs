// Boolean Logical Operators
bool isCool = false;
isCool = true; 

// Backwords saying
bool isTrue = !false;
bool isFalse = !true;

// AND Operator
// A part of the operator has to be false as well
bool trueANDExample = true && true;
bool falseANDExample = true && false;

// OR Operator
bool trueOrExample = true || false;
bool falseOrExample = false || false;

// XOR Operator
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

Console.WriteLine($"NOT False = {isTrue}");
Console.WriteLine($"False AND True = {falseANDExample}");
Console.WriteLine($"True OR True = {trueOrExample}");
Console.WriteLine($"True XOR True = {falseExclusiveOr}"); 