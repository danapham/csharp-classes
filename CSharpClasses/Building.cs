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
        }

        public void Construct() =>_dateConstructed = DateTime.Now;
        public void Purchase(string name) => _owner = name;

    }
}
