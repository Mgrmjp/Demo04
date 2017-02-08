using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Radio
    {
        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;

        private readonly double maxFreq = 26000.0;
        private readonly double minFreq = 2000.0;

        public bool Mode { get; set; }

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume && value >= minVolume) volume = value;
                else if (value > maxVolume)
                {
                    Console.WriteLine("Volume too high! Setting to maximum.");
                    volume = maxVolume;
                }
                else
                {
                    Console.WriteLine("Volume too low. Setting to minimum.");
                    volume = minVolume;
                }
            }
        }


        private double channel;
        public double Channel
        {
            get
            {
                return channel;
            }

            set
            {
                if (value <= maxFreq && value >= minFreq) channel = value;

                else if (value > maxFreq)
                {
                    Console.WriteLine("Frequency out of bounds. Setting to maximum.");
                    channel = maxFreq;
                }

                else if (value < minFreq)
                {
                    Console.WriteLine("Frequency out of bounds. Setting to minimum.");
                    channel = minFreq;
                }

            }
        }

    }
}
