using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses
{
    class City
    {
        private string _name { get; set; }
        private string _mayor { get; set; }
        private int _yearEstablished { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        public City(string name)
        {
            _name = name;
            _mayor = "Bernie Sanders";
        }

        public void Establish() => _yearEstablished = new DateTime().Year;
        public void AddBuilding(Building building)
        {
            Buildings.Add(building);
        }
    }
}
