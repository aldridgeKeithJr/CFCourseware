using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class RealEstate
    {
        ConsoleKeyInfo keyPressed;
        List<House> myHouses = null;
        
        public RealEstate()
        {
            myHouses = new List<House>();
        }

        public void AddHouse()
        {
            do
            {
                House house = new House();
                int selection;

                do
                {
                    Console.Clear();
                    Console.WriteLine("\nWhat type of house would you like to enter (1 or 2):\n");
                    Console.WriteLine("1. Single Family Residence");
                    Console.WriteLine("2. Townhome or Condo\n\n");
                    selection = Validate.Range(Console.ReadKey(true), 1, 2);
                    switch (selection)
                    {
                        case 1:
                            house.type = "Single Family Residence";
                            break;
                        case 2:
                            house.type = "Apartment or Condo";
                            break;
                    }
                } while (selection == -1);

                bool retVal;
                decimal result;
                do
                {
                    Console.WriteLine("\nHow many bedrooms?");
                    house.bedrooms = Console.ReadLine();
                    retVal = Validate.IsNumber(house.bedrooms, out result);
                } while (!retVal);
                do
                {
                    Console.WriteLine("\nHow many bathrooms?");
                    house.bathrooms = Console.ReadLine();
                    retVal = Validate.IsNumber(house.bathrooms, out result);
                } while (!retVal);
                do
                {
                    Console.WriteLine("\nEnter the square footage:");
                    house.sqft = Console.ReadLine();
                    retVal = Validate.IsNumber(house.sqft, out result);
                } while (!retVal);

                myHouses.Add(house);

                do
                {
                    Console.WriteLine("\nEnter another house? (Y/N)\n");
                    keyPressed = Console.ReadKey(true);
                } while (!Validate.IsYesNo(keyPressed));

            } while (keyPressed.Key == ConsoleKey.Y);
        }

        public int ViewHouses()
        {
            int index = 0;
            foreach (var item in myHouses)
            {
                Console.WriteLine(++index + ".  " + item.type + ", " + item.bedrooms + " bedrooms, " + item.bathrooms + " bathrooms, " + item.sqft + " square feet");
            }
            return myHouses.Count;
        }

        public void RemoveHouse()
        {
            int selection;

            do
            {
                Console.Clear();
                int numHouses = ViewHouses();
                Console.WriteLine("\nWhich house would you like to remove? (Enter the number, or ESC to cancel)\n");
                keyPressed = Console.ReadKey(true);
                if (Validate.IsEscape(keyPressed)) // user pressed the ESC key
                    return;
                selection = Validate.Range(keyPressed, 1, numHouses);
                if (selection != -1)
                {
                    House house = myHouses.ElementAt(selection - 1);
                    myHouses.Remove(house);
                    Console.Clear();
                    Console.WriteLine("\nHouse #" + selection + " has been condemned because it is infested with rabid wombats.\n\n");
                    ViewHouses();
                }
            }
            while (selection == -1);
        }
    }
}
