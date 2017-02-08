using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        public Boat()
        {
        }

        public override string ToString()
        {
            return base.ToString() + " | Seats > " + SeatCount + " | Type > " + BoatType;
        }
    }
}
