using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses
{
    public class Building
    {
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume => Width * Depth * 3;

        public Building(string address)
        {
            _address = address;
            _designer = "Dana Pham";
        }

        public void Construct() =>_dateConstructed = DateTime.Now;
        public void Purchase(string name) => _owner = name;
        public void DisplayInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }
}
