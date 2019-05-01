using System;
using System.Collections.Generic;
using System.Collections;

namespace urban_planner_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Building myBuilding = new Building("1239 25th Street")
            {
                Width = 15,
                Depth = 12,
                Stories = 2
            };
            Building railroadSociety = new Building("1323 8th Avenue")
            {
                Width = 20,
                Depth = 30,
                Stories = 1
            };
            Building staffordHouse = new Building("102 Roadway Street")
            {
                Width = 20,
                Depth = 40,
                Stories = 3
            };


            myBuilding.Construct(myBuilding);
            railroadSociety.Construct(railroadSociety);
            staffordHouse.Construct(staffordHouse);

            myBuilding.Purchase("Dianne Bird");
            railroadSociety.Purchase("Railroad Society");
            staffordHouse.Purchase("John Williams");

            List<object> listOfBuildings = new List<object>();
            listOfBuildings.Add(myBuilding);
            listOfBuildings.Add(railroadSociety);
            listOfBuildings.Add(staffordHouse);


            City huntington = new City("Huntington", listOfBuildings)
            {
                Mayor = "Steve Williams",
                yearEstablished = 1871,
            };

            myBuilding.Print();
            railroadSociety.Print();
            staffordHouse.Print();

            foreach (Building building in huntington.buildings)
            {
                building.Print();
            }
        }
    }
}
