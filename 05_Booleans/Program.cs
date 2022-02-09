// Boolean Logical Operators
// Negative Operator
bool isCool = false;
isCool = !true; 

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

// Comparison Operators
bool isGreaterThan = 10 > 10;
bool isGreaterThanorEqualTo = 10 >= 10;
Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 {isGreaterThanorEqualTo}");

bool isLessThan = 5 < 5;
bool isLessThanorEqualTo = 5 <= 5;
Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 {isLessThanorEqualTo}");

bool equality = 17 == 9;
bool inequality = 17 != 9;
Console.WriteLine($"17 == 9 and 17 !=9 are {equality} and {inequality}");

// Extra Work
// $ using a predefine bool/not just using a normal text
bool isEvil = true;
bool isHero = !false;  
Console.WriteLine($"All For One is a {isEvil}.");
Console.WriteLine($"Everyone wakes up wanting to be a {isHero}?");