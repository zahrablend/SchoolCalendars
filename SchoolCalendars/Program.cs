using SchoolCalendar.Children;
using SchoolCalendar.SchoolLegalSystem;

namespace SchoolCalendar
{
    internal class Program
    {
        static void Report(Child child, SchoolSystem school)
        {
            Console.WriteLine(
                child + " starts school on " + school.GetBeginning(child) + 
                ", celebrates on " + child.GetFirstCelebrationAt(school));
        }
        static void Main(string[] args)
        {
            SchoolSystem school =
                new SchoolSystem(new YearDate(3, 1), 5, new YearDate(8, 15));

            Child jill = new Child("Jill", new Date(2016, new YearDate(2, 29)));
            Child jake = new Child("Jake", new Date(2015, new YearDate(8, 27)));

            //Date birthdate = new Date(2016, new YearDate(2, 29));
            //Child schoolchild = new Child("Anna", birthdate);

            //Date schoolStart = school.GetBeginning(schoolchild);

            //Console.WriteLine(birthdate);
            //Console.WriteLine(schoolchild);
            //Console.WriteLine(schoolStart);

            //Console.ReadLine();
        }
    }
}