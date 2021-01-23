﻿using System;
using System.Collections.Generic;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 28.875;
            FiveOneTwoEigth.Depth = 32.725;
            FiveOneTwoEigth.Stories = 9;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Harmony Korine");

            City Nashville = new City("Nashville");
            Nashville.Establish();
            Nashville.AddBuilding(FiveOneTwoEigth);

            foreach (Building building in Nashville.Buildings)
            {
                building.DisplayInfo();
            }
        }
    }
}
