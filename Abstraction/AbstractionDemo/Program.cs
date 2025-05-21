using System;

/* This program is a simple example of abstraction where Vehicle is a abstract class(base class) with abstract method
    and Car and Bike are derived classes that implement the abstract methods.  Similarly FuelType is a property of Vehicle class (public)
    which is accesible publicly. 
*/


// Abstract class Vehicle with abstract methods
public abstract class Vehicle
    {
        protected string FuelType;         //declaring protected property FuelType so that every derived class can access it.
       
        public Vehicle(string fuelType) // Constructor to initialize FuelType
         {
        FuelType = fuelType;
         }
    public abstract void Start();
        public abstract void Stop();
        public abstract void Display();
    }



// Derived class Car implementing abstract methods
public class Car : Vehicle
    {
        public Car(string fuelType) : base(fuelType) { } //calling base class constructor to initialize FuelType
         public override void Start()
        {
            Console.WriteLine("Car starting with " + FuelType);
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped");
        }

        public override void Display()
        {
            Console.WriteLine("This is a car");
        }
    }

    // Derived class Bike implementing abstract methods
    public class Bike : Vehicle
    {

        public Bike(string fuelType) : base(fuelType) { }   //calling base class constructor to initialize FuelType
         public override void Start()
        {
            Console.WriteLine("Bike starting with " + FuelType);
        }

        public override void Stop()
        {
            Console.WriteLine("Bike stopped");
        }

        public override void Display()
        {
            Console.WriteLine("This is a bike");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle CarObject = new Car("Diesel" );  //Creating object of Car class Reference of Vehicle by which only vehicle class members can be accessed
            Vehicle BikeObject = new Bike("Petrol"); // Initiaing parent property at the time of object creation.

            CarObject.Display();
            CarObject.Start();
            CarObject.Stop();

            //Line breaker for better readability
             Console.WriteLine();

            BikeObject.Display();
            BikeObject.Start();
            BikeObject.Stop();
        }
    }
