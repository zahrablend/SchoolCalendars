using SchoolCalendar.SchoolLegalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCalendar.Children
{
    internal class Child
    {
        private string _name;
        private Date _birthdate;

        public Child(string name, Date birthdate)
        {
            _name = name;
            _birthdate = birthdate;
        }

        public Date GetDateByAge(int age) =>
            // Tell, don't ask principle:
            // Don't ask objects for their internal data,
            // but rather disclose part of the data available to you
            // and tell other objects what they should do for you
            // // using their private data and data you gave them.
            _birthdate.AddYears(age);

        //public override string ToString()
        //{
        //    return _name + " born on " + _birthdate;
        //}

        public override string ToString() => _name + " born on " + _birthdate;
    }
}
