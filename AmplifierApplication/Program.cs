using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmplifierApplication
{
    class Program
    {
        static void Main(string[] args)
        {
                Amplifier amplifier = new Amplifier();

                int luku;

                do
                {
                    Console.WriteLine("Volume is currently > " + amplifier.Volume);
                    Console.Write("Give a new volume value (0-100) > ");
                    string line = Console.ReadLine();
                    luku = int.Parse(line);

                    amplifier.Volume = luku;

                    Console.WriteLine();

                } while (luku != -1);

            }
        }
    }

