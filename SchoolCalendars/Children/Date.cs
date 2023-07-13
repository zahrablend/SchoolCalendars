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
        private Date FirstValidDate(YearDate day) => day.IsLeap() && !IsLeap(year) ? new Date(year, day.GetNext())
                : new Date(year, day);

        public Date GetFirstOccurence(YearDate day) => throw new NotImplementedException();

        public override string ToString() => _day + "/" + _year;
    }
}
