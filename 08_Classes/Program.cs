// Described as teh blueprint of data type
// Main components of how your program and data are organized
using Classes; 

Donut doug = new Donut ();
doug.donutType = "Jelly filled";
doug.SetDonutType("Glazed");
Console.WriteLine(doug.GetDonutType());

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
        public Donut(string type)
        {
            donutType = type;
        }

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
            public string SetDonutType(string type)
            {
                donutType = type;
            }
    }
}