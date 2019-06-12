namespace _05.UniqueNames
{
    using System;
    using System.Collections.Generic;

    class UniqueNames
    {
        static void Main()
        {
            int record = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < record; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
