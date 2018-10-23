using System;

namespace CarStruct
{
    struct Car {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate() {
            Console.WriteLine("Vroom!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.Make = "Mercedes";
            MyCar.Model = "GL450";
            MyCar.Color = "Black";

            Console.WriteLine("My car is a {0} {1} that is {2} in color.", MyCar.Make, MyCar.Model, MyCar.Color);
            MyCar.Accelerate();
        }
    }
}
