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

        public Date GetFirstOccurence(YearDate day) => throw new NotImplementedException();

        public override string ToString() => _day + "/" + _year;
    }
}
