using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiHommeli
{
    class Hissi
    {
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;

        private int floor = 1;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor && value >= minFloor) floor = value;

                else
                {
                    Console.WriteLine("Kari, stop messing with the elevator!");
                }
            }
        }

    
    }
}
