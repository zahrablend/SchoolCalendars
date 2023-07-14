using SchoolCalendar.Children;

namespace SchoolCalendar.SchoolLegalSystem
{
    internal class SchoolSystem
    {
        // state
        private readonly YearDate _cutoff;
        private readonly int _minAge;
        private readonly YearDate _schoolStart;

        public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutoff;
            _minAge = minAge;
            _schoolStart = schoolStart;
        }

        public Date GetBeginning(Child schoolchild) =>
            schoolchild
                .GetDateByAge(_minAge)
                .GetFirstOccurence(_cutoff)
                .GetFirstOccurence(_schoolStart);
    }
}
