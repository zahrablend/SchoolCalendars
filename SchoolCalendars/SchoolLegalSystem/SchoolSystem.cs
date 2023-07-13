using SchoolCalendar.Children;

namespace SchoolCalendar.SchoolLegalSystem
{
    internal class SchoolSystem
    {
        // state
        private YearDate _cutoff;
        private int _minAge;
        private YearDate _schoolStart;

        public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutoff;
            _minAge = minAge;
            _schoolStart = schoolStart;
        }
        public Date GetBeginning(Child schoolchild)
        {
            Date oldEnough = schoolchild.GetDateByAge(_minAge);
            Date cutoff = oldEnough.GetFirstOccurence(_cutoff);
            Date schoolday = cutoff.getFirstOccirence(_schoolStart);
            return schoolday;
        }
    }
}
