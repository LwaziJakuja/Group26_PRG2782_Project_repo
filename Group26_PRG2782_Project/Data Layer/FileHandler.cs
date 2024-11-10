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

        public List<Student> getData()
        {
            using(StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split(',');
                    students.Add(new Student(lines[0], lines[1], Convert.ToInt32(lines[2]), lines[3]));
                }

            }
            return students;
        }



    }
}
