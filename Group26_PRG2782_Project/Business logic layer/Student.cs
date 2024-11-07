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
        private int course;

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int Age { get => age; set => age = value; }
        public int Course { get => course; set => course = value; }
    }
}
