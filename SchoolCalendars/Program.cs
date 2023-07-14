using SchoolCalendar.Calendars;
using SchoolCalendar.Children;
using SchoolCalendar.SchoolLegalSystem;

namespace SchoolCalendar
{
    internal static class Program
    {
        static void Report(Child child, SchoolSystem school)
        {
            Console.WriteLine(
                child + " starts school on " + school.GetBeginning(child) + 
                ", celebrates on " + child.GetFirstCelebrationAt(school));
        }

        static void Demonstrate(Calendar cal)
        {
            var school =
                new SchoolSystem(cal.Create(3, 1), 5, cal.Create(8, 15));

            var jill = new Child("Jill", cal.Create(1892, 2, 29));
            var jake = new Child("Jake", cal.Create(1891, 8, 27));

            Console.WriteLine("Using " + cal.GetName() + " calendar:");
            Report(jill, school);
            Report(jake, school);
            Console.WriteLine();
        }
        static void Main()
        {
            Demonstrate(new GregorianCalendar());
            Demonstrate(new JulianCalendar());
            Console.ReadLine();
        }
    }
}