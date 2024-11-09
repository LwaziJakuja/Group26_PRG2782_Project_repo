using Group26_PRG2782_Project.Business_logic_layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group26_PRG2782_Project.Data_Layer
{
    internal class FileHandler
    {
        string filename = "Students.txt";
        List<Student> students = new List<Student>();

        public void AddNewStudent(Student student)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine($"{student.StudentId},{student.StudentName},{student.Age},{student.Course}");
            }
        }



    }
}
