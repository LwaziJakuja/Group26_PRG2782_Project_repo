using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Group26_PRG2782_Project.Business_logic_layer
{
    internal class Report
    {
        private List<Student> students;

        public Report(List<Student> students)
        {
            this.students = students;
        }

       
        public void GenerateSummaryReport()
        {
            int totalStudents = students.Count;
            double averageAge = students.Any() ? students.Average(s => s.Age) : 0;

            
            string filePath = "summary.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Summary Report");
                writer.WriteLine($"Total number of students: {totalStudents}");
                writer.WriteLine($"Average age of students: {averageAge:F2}");
            }
        }

        
        public (int TotalStudents, double AverageAge) GetSummaryData()
        {
            int totalStudents = students.Count;
            double averageAge = students.Any() ? students.Average(s => s.Age) : 0;
            return (totalStudents, averageAge);
        }
    }
}
