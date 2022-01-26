using System;

namespace UrbanPlanner
{
    public class City
    {
        //Name of the city.
        // The mayor of the city.
        // Year the city was established.
        // A collection of all of the buildings in the city.
        // A method to add a building to the city.

        public string CityName { get; set;}
        public string CityMayor { get; set; }
        public int CityYear { get; set; }
        public List<string> CityBuildings = new List<string> ();
        
        public void AddBuilding()
        {

        }


    }
}