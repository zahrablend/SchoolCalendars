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

        public Date GetDateByAge(int age)
        {
            throw new NotImplementedException();
        }

        //public override string ToString()
        //{
        //    return _name + " born on " + _birthdate;
        //}

        public override string ToString() => _name + " born on " + _birthdate;
    }
}
