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

        // 3: Expression-bodied method
        public Date GetBeginning(Child schoolchild) =>
            schoolchild
                .GetDateByAge(_minAge)
                .GetFirstOccurence(_cutoff)
                .GetFirstOccurence(_schoolStart);

        // 2:
        //public Date GetBeginning(Child schoolchild)
        //{ // Chaining method calls
        //    return schoolchild
        //        .GetDateByAge(_minAge)
        //        .GetFirstOccurence(_cutoff)
        //        .GetFirstOccurence(_schoolStart);

        // 1:
        //    // Procedures:
        //    //Date oldEnough = schoolchild.GetDateByAge(_minAge);
        //    //Date cutoff = oldEnough.GetFirstOccurence(_cutoff);
        //    //Date schoolday = cutoff.GetFirstOccurence(_schoolStart);
        //    //return schoolday;
        //}
    }
}
