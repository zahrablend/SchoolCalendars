using SchoolCalendar.Calendars;
using SchoolCalendar.SchoolLegalSystem;

namespace SchoolCalendar.Children
{
    internal class Date
    {
        private readonly int _year;
        private readonly YearDate _day;
        // Dependency
        private readonly Calendar _calendar;

        // Injecting dependency through costructor (dep. as 1st argument)
        public Date(Calendar calendar, int year, YearDate day)
        {
            _calendar = calendar;
            _year = year;
            _day = day;
        }

        public Date AddYears(int count) =>
            FirstValidDate(_year + count, _day);

        // Private as useful only for this class
        // Pattern matching with ternary operator
        private Date FirstValidDate(int year, YearDate day) => 
            new(_calendar, year, day.IsLeap() && !_calendar.IsLeapYear(year) ? day.GetNext() : day);

        public Date GetFirstDayOccurence(Date day) => 
            GetFirstDayOccurence(_year, day._day);

        // overloaded method
        public Date GetFirstOccurence(YearDate day) =>
            GetFirstDayOccurence(day.IsBefore(_day) ? _year + 1 : _year, day);

        private Date GetFirstDayOccurence(int year, YearDate day) =>
             new Date(_calendar, day.IsLeap() ? GetLeap(year) : year, day);


        // Recusion (calling a method from within itself: same object - different arguments)
        // IsLeap(year) is a termination condition
        private int GetLeap(int year) =>
            _calendar.IsLeapYear(year) ? year : GetLeap(year + 1);

        public override string ToString() => _day + "/" + _year;
    }
}
