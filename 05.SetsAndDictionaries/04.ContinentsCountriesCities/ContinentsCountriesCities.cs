namespace _04.ContinentsCountriesCities
{
    using System;
    using System.Collections.Generic;

    class ContinentsCountriesCities
    {
        static void Main()
        {
            int records = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < records; i++)
            {
                string[] entry = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = entry[0];
                string country = entry[1];
                string city = entry[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                }

                continents[continent][country].Add(city);
            }

            foreach (var pair in continents)
            {
                Console.WriteLine($"{pair.Key}:");

                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"    {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
