// Described as teh blueprint of data type
// Main components of how your program and data are organized
using Classes; 

Donut doug = new Donut ("Jelly Filled", true, false);
doug.SetDonutType("Glazed");
doug.Filling = "Strawberry Jam";
Console.WriteLine(doug.GetDonutType());
Console.WriteLine(doug.Filling);

Donut derrick = new Donut("Chocolate, Vanilla", true, false, 3.99);
Console.WriteLine(derrick.Price);

// NEW CLASS pt.2
Greeter greet = new Greeter();
Console.WriteLine(greet.SayHello("Bryon"));
greet.PrintHello("Ryo");
greet.PrintHello("Pearson");

greet.PrintRandomGreeting();

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Age(new DateTime(1990,06,01)));

Person me = new Person();
me.firstName = "Bryon";
me.lastName = "Pearson";
me.DateofBirth = new DateTime(1990,06,01);

me.Introduction();

namespace Classes
{
    class Donut
    {
        // shift alt f
        // Field    
        private string donutType;
        //Constructors
        // public Donut(){} <- Implicit constructor
        // v Defined constructor, implicit constructor removed
        public Donut(string type, bool sprinkles, bool icing)
        {
            donutType = type;
            IsSprinkles = sprinkles;
            HasIced = icing;
        }
        // Creating another "Donut" opens another lead way for "Donut", without using the one we have for Price
         public Donut(string type, bool sprinkles, bool icing, doubling price)
        {
            donutType = type;
            IsSprinkles = sprinkles;
            HasIced = icing;
            Price = price;
        }

            // Method V
            // 1       2      3
                public string GetDonut ()
            {
                // 4
                return donutType;
            }
            //1 Access modifier, private (only accessible within the classes), public (available everywhere), etc
            //2 Return type, when I run the method, what I get back
            //3 Method signature, Name(Parameters)
            //4 The body and the return
            public void SetDonutType(string type)
            {
                donutType = type;
            }

            // Filling Property
            public string Filling {get; set;}
            // Bool: making it a question statement as a true/false direction
            public bool IsSprinkles {get; set;}
            public bool HasIced {get; set;}
            public double Price {get; set;}
    }

    // NEW CLASS pt. 2
    class Greeter
    {
        Random _random = new Random();

        // Overload methods, same names but different parameters, SO: different signatures
        public string SayHello()
        {
            return "Hello!";
        }
        public string SayHello(string name)
        {
            return $"Hello {name}!";
        }
        
        public void PrintHello(string name)
        {
            Console.WriteLine($"Greetings {name}!");
        } 

        public void PrintRandomGreeting()
        {
            // Lists/arrays/eunumerable  index (starting) at zero      0        1       2      3...                                 5        
            string[] availableGreeting = new string[]{"Hello", "Howdy", "Sup", "Yo", "Good day to you good sir", "Wazzzzup"};
            int randomNumber = _random.Next(0,availableGreeting.Length);
            string randomgreeting = availableGreeting.ElementAt(randomNumber);
            Console.WriteLine(randomgreeting);
            // Every time you "run" this, the command will then choose a random number print it  
        }
    }
    
    class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        // Overload 
        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public int Divde(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        public int Remainder(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }
        public int Age(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            // To get years, converting from  Days to Years
            // Due to "our" calendar that the computer does not go by

            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            // Bc of Math.Floor, it will take away the dec. 
            return years; 
            // Cannot just do years bc you have to take in account of the months; have to use this coding calculator 
        }
    }

    class Person 
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        // ReadONLY Property (singel property - not going anywhere)
        public string fullName 
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public DateTime DatofBirth {get; set;}
        public int Age 
        {
            get
            {
                // DRY Style (not repeating oneself)
                // Already has the code above; used in one spot and referenced everywhere else
                Calculator calc = new Calculator();
                return calc.Age(DateofBirth);
            }
        }

        public void Greet()
        {
            Greeter greeter = new Greeter();
            // Semantic Satiation (using one word multiple times)
            greeter.PrintHello(fullName);
        }

        public void Introduction()
        {
            Greeter greeter = new Greeter();
            Console.WriteLine($"{greeter.PrintRandomGreeting}, my name is {fullName} and I am {Age} years old!"); 
    
        }
    }
}