 //-- Composite Formatting 
string first = "The cars we sell are";
string second = "BMW, Lexus, Mercedes and Lucid Air";
string third = "Used and New Cars";

// " " allows you to add additional information  
string concatenatedResult = first + "high, top performance, beauty, and priced beautifully " + second + third; 

Console.WriteLine(concatenatedResult);
            
string firstName = "Chris";
string lastName = "Mack";
            
string compositeResults = string.Format("His name is {0} {1}", firstName, lastName);
string compositeResults = string.Format("His name is {1} , {0}");

Console.WriteLine(compositeResults);
// Another way to format the above method
Console.WriteLine("His name is {0} {1}", firstName, lastName);
string interpolationResult = $"His name is still {firstName} {lastName}!";
Console.WriteLine(interpolationResult); 
Console.WriteLine($"His name is still {firstName} {lastName}!");

string interpolationResult = $"He does not want to change his name, but wants to be called Mr. {lastName}.";
        }