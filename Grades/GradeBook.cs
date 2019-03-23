using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public string Name { get; set; }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            var stats = new GradeStatistics();
            var sum = 0f;

            foreach (var grade in grades)
            {
                sum += grade;

                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
            }

            stats.AverageGrade = sum / grades.Count;


            return stats;
        }

        List<float> grades;
    }
}
