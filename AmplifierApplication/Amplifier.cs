using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Amplifier { 
    
    private readonly int maxVol = 100;
    private readonly int minVol = 0;

    private int volume = 0;
    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
                if (value <= maxVol && value >= minVol) volume = value;

                else if (value == -1);

                else 
                {
                    Console.WriteLine("- - Volume not valid! Setting to max (" + maxVol + ").");
                    volume = maxVol;
                }
            }
        }
    }
}
