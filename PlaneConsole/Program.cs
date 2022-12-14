using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaneLib;

namespace PlaneConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose an aircraft type: Airliner or Cargo \n");
            string planetype = Console.ReadLine();
            Console.WriteLine("Enter the type of the plane:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the destination of the plane:");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter the wingspan of the plane:");
            string wingspan = Console.ReadLine();
            Console.WriteLine("Enter the airline of the plane:");
            string airline = Console.ReadLine();
            Console.WriteLine("Enter the maximum height of the plane:");
            string maxheight = Console.ReadLine();
            Console.WriteLine("Enter the maximum speed of the plane:");
            string maxspeed = Console.ReadLine();
            Console.WriteLine("Enter the current speed of the plane:");
            string speed = Console.ReadLine();

            switch (planetype)
            {
                case "Airliner":
                    Console.WriteLine("Enter the number of passengers:");
                    string passengers = Console.ReadLine();
                    Airliner myairliner = new Airliner();
                    myairliner.type = type;
                    myairliner.destination = destination;
                    myairliner.wingspan = Convert.ToInt32(wingspan);
                    myairliner.airline = airline;
                    myairliner.maxheight = Convert.ToInt32(maxheight);
                    myairliner.maxspeed = Convert.ToInt32(maxspeed); 
                    myairliner.passengers = Convert.ToInt32(passengers);
                    myairliner.changespeed(Convert.ToInt32(speed));

                    Console.WriteLine($"\nInformation about Type:{myairliner.type};\nDestination:{myairliner.destination};" +
                        $"\nWingspan:{myairliner.wingspan};Airline:\n{myairliner.airline};\nMaximum height:{myairliner.maxheight};" +
                        $"\nMaximum speed:{myairliner.maxspeed};\nCurrent speed:{myairliner.speed};" +
                        $"\nThe number of passengers{myairliner.passengers};");

                    break;

                case "Cargo":
                    string cargo_type = Console.ReadLine();
                    Console.WriteLine("Enter the payload of the plane:");
                    string payload = Console.ReadLine();
                    CargoAircraft mycargoaircraft = new CargoAircraft();
                    mycargoaircraft.type = type;
                    mycargoaircraft.destination = destination;
                    mycargoaircraft.wingspan = Convert.ToInt32(wingspan);
                    mycargoaircraft.airline = airline;
                    mycargoaircraft.maxheight = Convert.ToInt32(maxheight);
                    mycargoaircraft.maxspeed = Convert.ToInt32(maxspeed);
                    mycargoaircraft.payload = Convert.ToInt32(payload);

                    mycargoaircraft.changespeed(Convert.ToInt32(speed));

                    Console.WriteLine($"\nInformation about\nType:{mycargoaircraft.type};\nDestination:{mycargoaircraft.destination};" +
                        $"\nWingspan:{mycargoaircraft.wingspan};\nAirline:{mycargoaircraft.airline};\nMaximum height:{mycargoaircraft.maxheight};" +
                        $"\nMaximum speed:{mycargoaircraft.maxspeed};\nCurrent speed:{mycargoaircraft.speed};" +
                        $"\nPayLoad capacity{mycargoaircraft.payload};");

                    break;
            }
            Console.ReadKey();
        }
    }
}
