using System;
using System.Collections.Generic;
using System.Collections;

namespace urban_planner_2
{
    public class Building
    {


        //Private
        private string _designer = "David Bird";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address { get; set; }
        private string _owner { get; set; }
        //End Private

        //Public
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Construct(Building building)
        {
            _dateConstructed = DateTime.Now;

        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public void Print()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
        //Building Constructor
        public Building(string address)
        {
            _address = address;
        }
        //End Constructor


    }
}
