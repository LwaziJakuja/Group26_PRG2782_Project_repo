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
        string summaryFile = "Summary.txt";
        List<Student> students;

        public void AddNewStudent(Student student)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine($"{student.StudentId},{student.StudentName},{student.Age},{student.Course}");
            }
        }

        public List<Student> getData()
        {
            students = new List<Student>();
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


        public List<Student> Search(string searchVal)
        {
            students = new List<Student>();
            using (StreamReader sr =new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lines = line.Split(',');
                    if (lines[1].Contains(searchVal))
                    {
                        students.Add(new Student(lines[0], lines[1], Convert.ToInt32(lines[2]), lines[3]));
                    }
                }
            }

            return students;
        }

        public void UpdateStudent(Student updatedStudent, string studentId)
        {

            try
            {
                var students = GetAllStudents();
                int index = students.FindIndex(s => s.StudentId == studentId);

                if (index >= 0)
                {
                    students[index] = updatedStudent;
                    SaveAllStudents(students);
                }
                else
                {
                    Console.WriteLine($"Student with ID {studentId} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student: {ex.Message}");
            }
        }

        public void DeleteStudent(string studentId)
        {
            try
            {
                var students = GetAllStudents();
                bool removed = students.RemoveAll(s => s.StudentId == studentId) > 0;

                if (removed)
                {
                    SaveAllStudents(students);
                }
                else
                {
                    Console.WriteLine($"Student with ID {studentId} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting student: {ex.Message}");
            }
        }

        private void SaveAllStudents(List<Student> students)
        {
            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.StudentId},{student.StudentName},{student.Age},{student.Course}");
                }
            }
        }
    }

    }
}
