namespace _06.ParkingLot
{
    using System;
    using System.Collections.Generic;

    class ParkingLot
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();

            string[] entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (entry[0]?.ToLower() != "end")
            {
                string direction = entry[0];
                string plate = entry[1];

                if (direction.ToLower() == "in")
                {
                    cars.Add(plate);
                }
                else if (direction.ToLower() == "out")
                {
                    cars.Remove(plate);
                }

                entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
