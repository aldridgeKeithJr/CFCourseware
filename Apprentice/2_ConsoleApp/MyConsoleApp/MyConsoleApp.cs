using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class MyConsoleApp
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyPressed;
            Garage myGarage = new Garage();
            RealEstate myRealEstate = new RealEstate();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select from the choices below:\n");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("  1.  Add real estate listings");
                Console.WriteLine("  2.  View real estate listings");
                Console.WriteLine("  3.  Remove a listing");
                Console.WriteLine("  4.  Add cars to garage");
                Console.WriteLine("  5.  View garage contents");
                Console.WriteLine("  6.  Remove a car");
                Console.WriteLine("  7.  Exit");

                keyPressed = Console.ReadKey(true);

                int selection = Validate.Range(keyPressed, 1, 7);

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        myRealEstate.AddHouse();
                        break;
                    case 2:
                        Console.Clear();
                        myRealEstate.ViewHouses();
                        Console.WriteLine("\n\nPress any key to return to the Main Menu...");
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.Clear();
                        myRealEstate.RemoveHouse();
                        Console.WriteLine("\n\nPress any key to return to the Main Menu...");
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.Clear();
                        myGarage.AddCars();
                        break;
                    case 5:
                        Console.Clear();
                        myGarage.ViewCars();
                        Console.WriteLine("\n\nPress any key to return to the Main Menu...");
                        Console.ReadKey(true);
                        break;
                    case 6:
                        Console.Clear();
                        myGarage.RemoveCar();
                        Console.WriteLine("\n\nPress any key to return to the Main Menu...");
                        Console.ReadKey(true);
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}
