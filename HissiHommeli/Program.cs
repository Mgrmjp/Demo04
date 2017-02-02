using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HissiHommeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            int luku;

            do
            {
                Console.WriteLine("\nYou're currently on floor " + hissi.Floor);
                Console.Write("Give a new floor (1-5) : ");
                string line = Console.ReadLine();
                luku = int.Parse(line);

                hissi.Floor = luku;

            } while (luku != 0);

        }
    }
}
