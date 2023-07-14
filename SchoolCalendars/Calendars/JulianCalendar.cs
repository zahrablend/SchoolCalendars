using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCalendar.Calendars
{
    internal class JulianCalendar : Calendar
    {
        public override string GetName() => "Julian";
        public override bool IsLeapYear(int year) =>
            year % 4 == 0;
    }
}
