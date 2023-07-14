using SchoolCalendar.Children;
using SchoolCalendar.SchoolLegalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCalendar.Calendars
{
    abstract class Calendar
    {
        public Date Create(int year, int month, int day) => 
            new Date(this, year, new YearDate(this, month, day));

        public YearDate Create(int month, int day) =>
            new YearDate(this, month, day);
        public abstract bool IsLeapYear(int year);
            

        public virtual bool IsLeapDay(int month, int day) =>
            month == 2 && day == 29;

        public virtual int MaxDaysInMonth(int month)
        {
            if (month is 4 or 6 or 9 or 11)
            {
                return month == 2 ? 29
            : 30;
            }
            else
            {
                return month == 2 ? 29
            : 31;
            }
        }

        public virtual int NextMonth(int afterMonth) =>
            afterMonth % 12 + 1;

        public abstract string GetName();
    }
}
