﻿using SchoolCalendar.Children;
using SchoolCalendar.SchoolLegalSystem;

namespace SchoolCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthdate = new Date(2016, new YearDate(2, 29));
            Child schoolchild = new Child("Anna", birthdate);

            Console.WriteLine(birthdate);
            Console.WriteLine(schoolchild);
            Console.ReadLine();
        }
    }
}