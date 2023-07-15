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
        private readonly string _name;
        private readonly Date _birthdate;

        public Child(string name, Date birthdate)
        {
            _name = name;
            _birthdate = birthdate;
        }
        public Date GetDateByAge(int age) =>
            _birthdate.AddYears(age);

        public Date GetFirstCelebrationAt(SchoolSystem school) =>
            school.GetBeginning(this).GetFirstDayOccurence(_birthdate);
        public override string ToString() => _name + " born on " + _birthdate;

        
    }
}
