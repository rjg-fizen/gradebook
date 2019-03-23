using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var speech = new SpeechSynthesizer();
            speech.Speak("Hello! This is the grade book program.");

            var book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(75f);


            var gradeStats = book.ComputeStatistics();
            Console.WriteLine($"The highest grade in the book is {gradeStats.HighestGrade}");
            Console.WriteLine($"The lowest grade in the book is {gradeStats.LowestGrade}"); 
            Console.WriteLine($"All grades averaged {gradeStats.AverageGrade}");

        }
    }
}
