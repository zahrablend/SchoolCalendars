using SchoolCalendar.SchoolLegalSystem;

namespace SchoolCalendar.Children
{
    internal class Date
    {
        private int _year;
        private YearDate _day;

        public Date(int year, YearDate day)
        {
           _year = year;
            _day = day;
        }

        public Date AddYears(int count) =>
            FirstValidDate(_year + count, _day);

        // Private as useful only for this class
        // Pattern matching with ternary operator
        private Date FirstValidDate(int year, YearDate day) => 
            day.IsLeap() && !IsLeap(year) ? new Date(year, day.GetNext())
                : new Date(year, day);

        public Date GetFirstDayOccurence(Date day) => 
            GetFirstDayOccurence(_year, day._day);

        private bool IsLeap(int year) =>
            year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public Date GetFirstOccurence(YearDate day) =>
            GetFirstDayOccurence(day.IsBefore(_day) ? _year + 1 : _year, day);

        private Date GetFirstDayOccurence(int year, YearDate day) =>
             new Date(day.IsLeap() ? GetLeap(year) : year, day);


        // Recusion (calling a method from within itself: same object - different arguments)
        // IsLeap(year) is a termination condition
        private int GetLeap(int year) =>
            IsLeap(year) ? year : GetLeap(year + 1);

        public override string ToString() => _day + "/" + _year;
    }
}
