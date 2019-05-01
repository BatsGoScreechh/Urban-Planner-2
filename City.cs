using System;
using System.Collections.Generic;
using System.Collections;

namespace urban_planner_2
{
    public class City
    {
        private string _cityName { get; set; }
        public string Mayor { get; set; }
        public int yearEstablished { get; set; }

        public List<object> buildings { get; set; }

        public City(string name, List<object> listBuildings)
        {
            _cityName = name;
            buildings = listBuildings;
        }

    }

}
