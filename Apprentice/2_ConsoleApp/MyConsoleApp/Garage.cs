using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
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
                Car car = new Car();
                int retVal;
                do
                {
                    Console.WriteLine("Enter the year: ");
                    car.year = Console.ReadLine();
                    retVal = (int)Validate.Range(car.year, 1900, DateTime.Now.Year);
                } while (retVal == -1);
                Console.WriteLine("Enter the make: ");
                car.make = Console.ReadLine();
                Console.WriteLine("Enter the model: ");
                car.model = Console.ReadLine();
                myCars.Add(car);
                do
                {
                    Console.WriteLine("Would you like to add another car? (Y/N)");
                    keyPressed = Console.ReadKey(true);
                } while (!Validate.IsYesNo(keyPressed));

            } while (keyPressed.Key == ConsoleKey.Y);
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

        public void RemoveCar()
        {
            int selection;

            do
            {
                Console.Clear();
                int numCars = ViewCars();
                Console.WriteLine("Which car would you like to remove? (Enter the number, or ESC to cancel)\n");
                keyPressed = Console.ReadKey(true);
                if (Validate.IsEscape(keyPressed)) // user pressed the ESC key
                    return;
                selection = Validate.Range(keyPressed, 1, numCars);
                if (selection > -1)
                {
                    Car car = myCars.ElementAt(selection - 1);
                    myCars.Remove(car);
                    Console.Clear();
                    Console.WriteLine("\nCar #" + selection + " is gone because it has been eaten by wombats.\n\n");
                    ViewCars();
                }
            }
            while (selection == -1);
        }
    }
}
