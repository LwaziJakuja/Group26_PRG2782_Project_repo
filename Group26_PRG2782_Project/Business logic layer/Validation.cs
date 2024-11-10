using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group26_PRG2782_Project.Business_logic_layer
{
    internal class Validation
    {
        public bool isEmpty(string studentId, string studentName, int studentAge, string course)
        {
            bool valid = true;

            if (studentId == "")
            {
                valid = false;
                MessageBox.Show("Student Id not filled in");
            }

            if (studentName == "")
            {
                valid = false;
                MessageBox.Show("Student Name cannot be empty!");
            }

            if (studentAge == null)
            {
                valid = false;
                MessageBox.Show("Student Age cannot be empty!");
            }

            if (course == "")
            {
                valid = false;
                MessageBox.Show("Course Code cannot be empty!");
            }
            return valid;
        }

        public bool validAge(int age)
        {
            bool valid = false;

            if(age >= 18)
            {
                valid=true;
            }
            else
            {
                MessageBox.Show("Student must be 18 years or older!");
            }

            return valid;
        }

        public bool uniqueID(string Id, List<Student> students)
        {
            bool result = true;
            foreach (Student student in students)
            {
                if (student.StudentId.Equals(Id))
                {
                    result = false;
                    MessageBox.Show($"Student Id: {Id}. Already exists!");
                }
            }
            return result;
        }
    }
}
