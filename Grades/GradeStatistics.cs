using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public float HighestGrade;
        public float AverageGrade;
        public float LowestGrade;

        public GradeStatistics()
        {
            HighestGrade = 0f;
            LowestGrade = float.MaxValue;
        }
    }
}
