using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Quest3
    {
    class Program
        {
            static void Main()
            {
                Hashtable daysOfWeek = new Hashtable();
                daysOfWeek.Add(1, "Sunday");
                daysOfWeek.Add(2, "Monday");
                daysOfWeek.Add(3, "Tuesday");
                daysOfWeek.Add(4, "Wednesday");
                daysOfWeek.Add(5, "Thursday");
                daysOfWeek.Add(6, "Friday");
                daysOfWeek.Add(7, "Saturday");

                // Find Tuesday
                bool hasTuesday = daysOfWeek.ContainsValue("Tuesday");
                Console.WriteLine(hasTuesday ? "Tuesday found!" : "Tuesday not found!");

                // Print out the days of the week
                foreach (DictionaryEntry day in daysOfWeek)
                {
                    Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
                }
            }
        }

    }
}
