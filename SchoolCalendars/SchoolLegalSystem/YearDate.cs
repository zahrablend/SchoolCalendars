using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCalendar.SchoolLegalSystem
{
    internal class YearDate
    {
        private int _month;
        private int _day;

        public YearDate(int month, int day)
        {
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
            return _month + "/" + _day;
        }
    }
}
