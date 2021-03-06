﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string YearModel { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
        }

        public override string ToString()
        {
            return "| Name > " + Name + " | Model > " + Model + " | YearModel > " + YearModel + " | Color > " + Color;
        }
    }

        
}
