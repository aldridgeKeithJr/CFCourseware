using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            RealEstate r = new RealEstate();
            Garage g = new Garage();
            
            while(true)
            {
                Console.WriteLine("Please select from the choice below:");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Add real estate listings");
                Console.WriteLine("2. View real estate listings");
                Console.WriteLine("3. Remove a listing");
                Console.WriteLine("4. Add cars to garage");
                Console.WriteLine("5. View garage contents");
                Console.WriteLine("6. Remove a car");
                Console.WriteLine("7. Exit");

                cki = Console.ReadKey(true);
                
                switch(cki.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Clear();
                        r.AddHouse();
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.WriteLine("User pressed a 2");
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.WriteLine("User pressed a 3");
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        Console.Clear();
                        g.AddCars();
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        Console.Clear();
                        g.ViewCars();
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        Console.Clear();
                        g.RemoveCar();
                        break;
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        return;
                }
                Console.ReadLine();
            }
        }
    }
}
