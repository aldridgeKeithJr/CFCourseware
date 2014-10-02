using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();
            ConsoleKeyInfo input;
            bool answer=true;
            do
            {
                var car = new Car();
                Console.WriteLine("Please enter the car make:");
                car.Make = Console.ReadLine();
                Console.WriteLine("Please enter the car model:");
                car.Model = Console.ReadLine();
                myCars.Add(car);

                Console.WriteLine("Would you like to enter another car? (y/n)");
                input = Console.ReadKey();

                if (input.Key != ConsoleKey.Y)
                {
                    answer = false; 
                }
            }
            
            while(answer == true);

            Console.WriteLine("Hit Enter to see the cars...");
            Console.ReadLine();

            foreach (var item in myCars)
            {
                Console.WriteLine("Make:  " + item.Make);
                Console.WriteLine("Model:  " + item.Model);
            }
            Console.ReadLine();
        }
    }
}

