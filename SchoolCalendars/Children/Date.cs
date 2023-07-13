﻿using SchoolCalendar.SchoolLegalSystem;

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

        public override string ToString()
        {
            return _day + "/" + _year;
        }
    }
}
