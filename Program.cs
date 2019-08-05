using System;
using System.Collections.Generic;
using System.Linq;
namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            List<Car> newCar = new List<Car>();

            newCar.Add(new Car("Nikolai", "Model S", 2017, 54999.99));
            newCar.Add(new Car("Ford", "Edge", 2017, 31999.90));
            newCar.Add(new Car("Chewie", "Vette", 2017, 44989.95));
            newCar.Add(new Car("Hyonda", "Prior", 2017, 23795.50));
            newCar.Add(new Car("Ford", "Focus", 2003, 6999.99));
            newCar.Add(new UsedCar("Ford", "Fusion", 2006, 5599.99, 160000));
            newCar.Add(new UsedCar("Toyota", "Corrola", 2004, 5999.99, 110000));


            while (keepGoing == true)
            {
                for (int i = 0; i < newCar.Count; i++)
                {
                    Car c = newCar[i];
                    Console.WriteLine($"{i + 1})\t{newCar[i]}");
                }
                int quitingTime = newCar.Count + 1;
                Console.WriteLine($"{quitingTime})\tQuit");

                Console.WriteLine("\nWhat car would you like?\n");

                string carNumber = Console.ReadLine();
                int carIdNumber = int.Parse(carNumber);
                int carChoice = carIdNumber - 1;

                if (carIdNumber == quitingTime)
                {
                    keepGoing = false;
                    Console.WriteLine("\nHave a wonderful day!");
                    break;
                }

                Console.WriteLine($"\n{newCar[carChoice]}");
                Console.WriteLine("\nWould you like to purchase this car? Yes or No\n");

                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("\nExcelent our finace team will be in contact shorty\n");
                    newCar.Remove(newCar[carChoice]);
                }
                else if (answer == "no" || answer == "n")
                {
                    Console.WriteLine("\nLets pick a differnt car\n");
                    continue;
                }
            }
        }
    }
}
