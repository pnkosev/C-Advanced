namespace _02.AverageStudentGrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AverageStudentGrade
    {
        static void Main()
        {
            int records = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < records; i++)
            {
                string[] entry = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string student = entry[0];
                double grade = double.Parse(entry[1]);

                if (!students.ContainsKey(student))
                {
                    students[student] = new List<double>();
                }

                students[student].Add(grade);
            }

            foreach (var pair in students)
            {
                Console.WriteLine($"{pair.Key} -> {string.Join(" ", pair.Value.Select(i => i.ToString("F2")))} (avg: {pair.Value.Average():f2})");
            }
        }
    }
}
