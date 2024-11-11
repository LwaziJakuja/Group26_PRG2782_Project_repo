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
        public bool isEmpty(string studentId, string studentName, string course)
        {
            bool valid = true;
            //check for empty values
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

            if (course == "")
            {
                valid = false;
                MessageBox.Show("Course Code cannot be empty!");
            }
            return valid;
        }

        public bool validAge(int age)
        {   //ensureing student age is above 18
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
            //earching through user data to ensure entered studentId is not alread used
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

        public bool isInteger(string Age)
        {
            bool result = false;

            // Parse the age safely
            if (!int.TryParse(Age, out int age))
            {
                MessageBox.Show("Invalid age. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
    }
}
