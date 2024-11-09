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

        
    }
}
