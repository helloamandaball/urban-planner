using System;

namespace UrbanPlanner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BUILD YOUR CITY:
                //Create several buildings in the Main() method of Program.cs
                //Give each building a width, height, and number of stories.
                // Construct each building.
                // Have business people in your city purchase each of your buildings.
                //After all of the buildings have been purchased, display the address, designer, constructed date, owner, and volume
            //Building YellowBrick... is like saying var YellowBrick...  
            Building YellowBrick = new Building("200 Yellow Brick Road")//Because we added an address param, it's expecting something to go into the parenthesis
            { //Add properties of Depth, Width and Stories
                Depth = 60,
                Width = 40,
                Stories = 4
            };
            //Could also add a property by adding code outside the curly brackets for the constructor of Building: 
            //YellowBrick.Depth = 100 ;

            YellowBrick.Construct();//Will get a DateTime
            YellowBrick.Purchase("Dorothy Gale");
            //Display the address, designer, dateConstructed, owner, Volume
            YellowBrick.PrintBldgInfo();

            Building BagEnd = new Building("1 Bagshot Row")
            {
                Depth = 20,
                Width = 20,
                Stories = 1
            };

            BagEnd.Construct();
            BagEnd.Purchase("Bilbo Baggins");
            //Display the address, designer, dateConstructed, owner, Volume
            BagEnd.PrintBldgInfo();

            List<Building> Neighborhood = new List<Building>()
            {
                YellowBrick,
                BagEnd
            };
            Console.WriteLine(Neighborhood.Count);

            // //Can do it in a foreach loop for all instead of doing a call for each one
            //foreach example 1
            // foreach (Building house in Neighborhood)
            // {
            //     house.PrintBldgInfo();
            // }

            //foreach example 2
            Neighborhood.ForEach(house => {
                house.PrintBldgInfo();
            });

        }
    }
}
