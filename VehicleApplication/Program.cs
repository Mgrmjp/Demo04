using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike();
            Bike bike2 = new Bike();
            Boat boat1 = new Boat();
            Boat boat2 = new Boat();

            bike1.Name = "Sellane";
            bike1.Model = "Envrmnt";
            bike1.YearModel = "2020";
            bike1.Color = "Black";
            bike1.GearWheels = false;
            bike1.GearName = "";

            bike2.Name = "Tollane";
            bike2.Model = "Strt";
            bike2.YearModel = "1990";
            bike2.Color = "Red";
            bike2.GearWheels = true;
            bike2.GearName = "Kylkulukee";

            Console.WriteLine("Bike 1 info -- ");
            Console.WriteLine(bike1.ToString() + "\n");

            Console.WriteLine("Bike 2 info --");
            Console.WriteLine(bike2.ToString() + "\n");
            

            boat1.Name = "Venehe";
            boat1.Model = "Kova";
            boat1.YearModel = "1337";
            boat1.Color = "Rainbow";
            boat1.SeatCount = 6;
            boat1.BoatType = "Rowboat";

            boat2.Name = "SS Kurw";
            boat2.Model = "JJ50";
            boat2.YearModel = "2017";
            boat2.Color = "Cyan";
            boat2.SeatCount = 2;
            boat2.BoatType = "Submarine";

            Console.WriteLine("Boat 1 info -- ");
            Console.WriteLine(boat1.ToString() + "\n");
            Console.WriteLine("Boat 2 info -- ");
            Console.WriteLine(boat2.ToString() + "\n");
            
        }
    }
}
