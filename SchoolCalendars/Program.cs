﻿using SchoolCalendar.Calendars;
using SchoolCalendar.Children;
using SchoolCalendar.SchoolLegalSystem;

namespace SchoolCalendar
{
    internal static class Program
    {
        static void Report(Child[] children, SchoolSystem school)
        {
            foreach (Child child in children)
            {
                Console.WriteLine(child + " starts school on " + school.GetBeginning(child) +
                ", celebrates on " + child.GetFirstCelebrationAt(school));
            }
        }

        static void Demonstrate(Calendar cal)
        {
            var school =
                new SchoolSystem(cal.Create(3, 1), 5, cal.Create(8, 15));

            Report(Array.Empty<Child>(), school);

            Child[] children = new Child[]
            {
                new Child("Jill", cal.Create(2008, 2, 29)),
                new Child("Jake", cal.Create(2007, 8, 27)),
                new Child("Jimmy", cal.Create(2008, 1, 31)),
                new Child("Jane", cal.Create(2009, 4, 22)),
                new Child("John", cal.Create(2007, 11, 14))
            };

            Console.WriteLine("Using " + cal.GetName() + " calendar:");
            Report(children, school);
            Console.WriteLine();
        }
        // Utility method
        static void AddCalendars(List<Calendar> calendars)
        {
            calendars.Add(new JulianCalendar());
        }
        static void Main()
        {
            List<Calendar> calendars = new List<Calendar>()
            {
                new GregorianCalendar()
            };
            
            AddCalendars(calendars);

            foreach (Calendar calendar in calendars)
            {
                Demonstrate(calendar);
            }

            Console.ReadLine();
        }
    }
}