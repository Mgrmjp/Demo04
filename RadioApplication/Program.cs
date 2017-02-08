using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            bool swz;
            double chn;
            int vol;
            string input;


            do
            {
                Console.WriteLine("\nRadio is ON = " + radio.Mode);
                Console.Write("Is radio on? ");
                string line = Console.ReadLine();
                input = line.ToLower();
                if (input == "yes")
                {
                    swz = true;
                    radio.Mode = swz;
                }
                else
                {
                    swz = false;
                    radio.Mode = swz;
                    break;
                }

                Console.WriteLine("\nChannel is currently " + radio.Channel);
                Console.Write("Give a frequency (2000.0 - 26000.0) ");
                chn = Convert.ToDouble((Console.ReadLine()));
                radio.Channel = chn;

                Console.WriteLine("\nVolume is currently " + radio.Volume);
                Console.Write("Set volume (0-9) ");
                line = Console.ReadLine();
                vol = int.Parse(line);
                radio.Volume = vol;

            } while (swz == true);
        }
    }
}
