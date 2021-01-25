using System;

namespace Slask
{
       class Car
    {
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public Person Owner { get; set; }

        public override string ToString()
        {
            return string.Format("En {0} med registreringsnummer {1}, ägs av {2}", Model, RegistrationNumber, Owner.ToString());
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2} år gammal.", FirstName, LastName, Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                        //Metod ett
            Car car = new Car { Model = "Volvo", RegistrationNumber = "ABC123", Owner = new Person { FirstName = "Fredrik", LastName = "Karlsson", Age = 19 } };
            //Metod två
            Car car2 = new Car();
            car2.Model = "Volvo";
            car2.RegistrationNumber = "ABC123";

            car2.Owner = new Person();
            car2.Owner.FirstName = "Fredrik";
            car2.Owner.LastName = "Karlsson";
            car2.Owner.Age = 19;

            Console.Write(car.ToString());
            Console.Readline();
                        
        }
    }
}
