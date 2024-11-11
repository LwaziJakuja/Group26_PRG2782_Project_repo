using Group26_PRG2782_Project.Data_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Group26_PRG2782_Project.Business_logic_layer
{
    internal class Report
    {
        private List<Student> students;
        private int totalStudents;
        private double averageAge;
        FileHandler handler = new FileHandler();

        public Report(List<Student> students)
        {
            this.students = students;
        }

        public int TotalStudents { get => totalStudents; set => totalStudents = value; }
        public double AverageAge { get => averageAge; set => averageAge = value; }

        public void GenerateSummaryReport()
        {
            totalStudents = students.Count;
            averageAge = students.Any() ? students.Average(s => s.Age) : 0;

            handler.SaveReport(totalStudents, averageAge);
            
        }

        
        public (int TotalStudents, double AverageAge) GetSummaryData()
        {
            totalStudents = students.Count;
            averageAge = students.Any() ? students.Average(s => s.Age) : 0;
            return (totalStudents, averageAge);
        }
    }
}
