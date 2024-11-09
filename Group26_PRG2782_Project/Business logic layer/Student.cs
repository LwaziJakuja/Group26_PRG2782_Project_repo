using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group26_PRG2782_Project.Business_logic_layer
{
    internal class Student
    {
        private string studentId;
        private string studentName;
        private int age;
        private string course;

        public Student() 
        {
            
        }

        public Student(string studentId, string studentName, int age, string course)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.age = age;
            this.course = course;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
    }
}
