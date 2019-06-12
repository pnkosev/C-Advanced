namespace _03.ProductShop
{
    using System;
    using System.Collections.Generic;

    class ProductShop
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (entry[0]?.ToLower() != "revision")
            {
                string shop = entry[0];
                string product = entry[1];
                double price = double.Parse(entry[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop][product] = price;
                }

                entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var pair in shops)
            {
                Console.WriteLine($"{pair.Key}->");

                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
