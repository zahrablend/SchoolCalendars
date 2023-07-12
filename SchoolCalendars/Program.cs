namespace SchoolCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthdate = new Date(2018, 2, 29);
            Child schoolchild = new Child("Anna", birthdate);

            Console.WriteLine("Hello, World!");
        }
    }
}