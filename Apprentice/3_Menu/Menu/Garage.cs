using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Garage
    {
        ConsoleKeyInfo keyPressed;
        List<Car> myCars;

        public Garage()
        {
            myCars = new List<Car>();
        }

        public void AddCars()
        {
            do
            {
                Console.Clear();
                Car c = new Car();
                
                Console.WriteLine("Enter the year: ");
                c.year = Console.ReadLine();
                Console.WriteLine("Enter the make");
                c.make = Console.ReadLine();
                Console.WriteLine("Enter the model");
                c.model = Console.ReadLine();
                myCars.Add(c);

                Console.WriteLine("Would you like to add another car?");
                keyPressed = Console.ReadKey();
                
            }while(keyPressed.Key == ConsoleKey.Y);
        }

        public void RemoveCar()
        {
            int numCars = ViewCars();
            Console.WriteLine("Which car would you like to remove? (Enter the number, or ESC to cancel)\n");
            keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.Escape) // user pressed escape to cancel
            {
                return;
            }

            int keyValue = (int)char.GetNumericValue(keyPressed.KeyChar);
            Car carToRemove = myCars.ElementAt(keyValue - 1);
            myCars.Remove(carToRemove);
            Console.WriteLine("\nCar # " + keyValue + " was stolen by rabid wombats.\n");
            ViewCars();
        }

        public int ViewCars()
        {
            int index = 0;
            foreach (var item in myCars)
            {
                Console.WriteLine((++index) + ".  " + item.year + " " + item.make + " " + item.model);
            }
            return myCars.Count;
        }
    }
}
