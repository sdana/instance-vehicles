using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{


    public class Program
    {

        public static void Main()
        {

            // Build a collection of all vehicles that fly
            Cessna charlieCessna = new Cessna();
            SeaPlane littleMermaid = new SeaPlane();
            SevenFortySeven flight919 = new SevenFortySeven();

            charlieCessna.Name = "Charlie";
            littleMermaid.Name = "Little Mermaid";
            flight919.Name = "Flight 919";

            List<Flyers> thingsThatFly = new List<Flyers>();
            thingsThatFly.Add(charlieCessna);
            thingsThatFly.Add(littleMermaid);
            thingsThatFly.Add(flight919);

            // With a single `foreach`, have each vehicle Fly()

            foreach (Flyers flight in thingsThatFly)
            {
                System.Console.WriteLine($"{flight.Name} has {flight.Fly()}");
            }

            // Build a collection of all vehicles that operate on roads
            List<Drivers> thingsThatDrive = new List<Drivers>(){
                new Motorcycle(){
                    Name = "Rita",
                    Type = "Motorcycle"
                },
                new Jeep(){
                    Name = "Dad's Jeep",
                    Type = "JEEP"
                },
                new Amphicar(){
                    Name = "Big Mermaid",
                    Type = "Aqua Car"
                },
            };

            // With a single `foreach`, have each road vehicle Drive()

                foreach (Drivers thing in thingsThatDrive)
                {
                    System.Console.WriteLine($"{thing.Name} the {thing.Type} is {thing.Drive()} with its {thing.Wheels} wheels");
                }


            // Build a collection of all vehicles that operate on water

            // With a single `foreach`, have each water vehicle Drive()
        }

    }
}