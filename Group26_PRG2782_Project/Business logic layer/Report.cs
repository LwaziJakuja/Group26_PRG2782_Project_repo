using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group26_PRG2782_Project.Business_logic_layer
{
    internal class Report
    { 
        {
        private List<Student> students;
 
        public ReportForm(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
 
            
            DisplaySummary();
        }
 
        private void DisplaySummary()
        {
            int totalStudents = students.Count;
 
            
            double averageAge = students.Any() ? students.Average(s => s.Age) : 0;
 
            
            txtTotalStudents.Text = totalStudents.ToString();
            txtAverageAge.Text = averageAge.ToString("F2");
 
            
            SaveSummaryToFile(totalStudents, averageAge);
        }
 
        private void SaveSummaryToFile(int totalStudents, double averageAge)
        {
            string filePath = @"C:\Users\sophi\Desktop\PRG272\ReportSummary.txt";
 
 
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Summary Report");
                writer.WriteLine($"Total number of students: {totalStudents}");
                writer.WriteLine($"Average age of students: {averageAge:F2}");
            }
 
            MessageBox.Show("Summary saved to ReportSummary.txt", "Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
        private void btnBackToDatabase_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }
    }

    }
}
