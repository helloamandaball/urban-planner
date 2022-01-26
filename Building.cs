using System;

namespace UrbanPlanner
{
    //In this exercise, you are going to define your own Building type and create several instances of it to design your own virtual city.
    // Create a class named Building in the Building.cs file and define the following fields, properties, and methods.
    public class Building
    {
        //Private Fields:
        private string _designer = "am&a";
        private DateTime _dateConstructed  { get; set; }
        private string _address  { get; set; }
        private string _owner  { get; set; }

        //Public Fields:
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume {
            get { return Width * Depth * (3 * Stories); }
            //Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
            //Don't need a set because we don't need to assign a value to the variable since its read-only
        }

        //Constructor Method:
            //Define a constructor method that accepts a single string argument - address - so that you can send as a parameter when you create each instance with new Building("800 8th Street");.
            //The constructor's logic should set the _address field's value to the argument value //address is the argument
            //Usually only one Constructor per Class and the names should match, in this case it's called Building
        public Building (string address)//This "Building" is a function, address is a parameter
        {
            _address = address;
        }

        //Public Methods:
            // Define a Construct() method. The method's logic should set the _dateConstructed field's value to DateTime.Now.
            // Define a Purchase() method. The method should accept a single string argument of the name of the person purchasing a building. The method should take that string and assign it to the private _owner field.
            // Neither of these methods will return a value. //this means make it a void!
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        //Created another method for displaying the building's info, like the "Ship" method created in the practice tinkerToys example from Ch.13 mixed with the video C# Classes Tutorial by Mosh and the video How to Program C# by Brackeys.
        public void PrintBldgInfo()
        {
            Console.WriteLine($"{_address}"); //
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine();
        }
    }
}