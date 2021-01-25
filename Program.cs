using System;

namespace Uppgift_7
{
// Abstract class
    abstract class Vehicle
    {
        public abstract void VehicleColorAndMake();
    //public abstract void VehicleMake();
    }

    class Car : Vehicle
    {
        string color;
        string make;
        public override void VehicleColorAndMake() 
        {
            Console.WriteLine("The make of the car is " + make + " and the color is " + color);
        }
        
        // Constructor
        public Car ()
        { 
            Random numberGenerator = new Random();
            int num = numberGenerator.Next(1,4);

            switch (num)
            {
                case 1: color = "red"; break;
                case 2: color = "blue"; break;                
                case 3: color = "green"; break;
                case 4: color = "black"; break;
            }
            num = numberGenerator.Next(1,4);
            switch (num)
            {
                case 1: make = "Corvette"; break;
                case 2: make = "Buick"; break;                
                case 3: make = "Cadillac"; break;
                case 4: make = "Pontiac"; break;
            }
        }
    }  
    class StarShip : Vehicle
    {
        string color;
        string make = "w";
        public override void VehicleColorAndMake() 
        {
            Console.WriteLine("The make of the Star ship is " + make + " and the color is " + color);
        }
        
        // Constructor
        public StarShip ()
        { 
            Random numberGenerator = new Random();
            int num = numberGenerator.Next(1,4);

            switch (num)
            {
                case 1: color = "red"; break;
                case 2: color = "blue"; break;                
                case 3: color = "green"; break;
                case 4: color = "black"; break;
            }

            num = numberGenerator.Next(1,4);
            switch (num)
            {
                case 1: make = "Falcon Millenium"; break;
                case 2: make = "Tie Fighter"; break;                
                case 3: make = "Xwing"; break;
                case 4: make = "Star Destroyer"; break;
            }
        }
    }

   class Bicycle : Vehicle
    {
        string color;
        string make;
        public override void VehicleColorAndMake() 
        {
            Console.WriteLine("The make of the bicycle is  " + make + " and the color is " + color);
        }
        
        // Constructor
        public Bicycle ()
        { 
            Random numberGenerator = new Random();
            int num = numberGenerator.Next(1,4);

            switch (num)
            {
                case 1: color = "red"; break;
                case 2: color = "blue"; break;                
                case 3: color = "green"; break;
                case 4: color = "black"; break;
            }

            num = numberGenerator.Next(1,4);
            switch (num)
            {
                case 1: make = "Cresent"; break;
                case 2: make = "DBS"; break;                
                case 3: make = "Monark"; break;
                case 4: make = "Skeppshult"; break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            int num;
            Vehicle[] vehicle = new Vehicle[4];

            for (int i = 0; i < 4; i++)
            {
                num = numberGenerator.Next(1,4);
                switch (num)
                {
                    case 1: vehicle[i] = new Car(); break;
                    case 2: vehicle[i] = new StarShip(); break;
                    case 3: vehicle[i] = new Bicycle(); break;
                    case 4: vehicle[i] = new Car(); break;
                }
            }        
        
            for (int i = 0; i < 4; i++)
            {
                vehicle[i].VehicleColorAndMake();       
            }

            Console.ReadKey();
        }
    }
}
