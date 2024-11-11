using Group26_PRG2782_Project.Business_logic_layer;
using Group26_PRG2782_Project.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Mangement_Application.Presentation_Layer
{
    public partial class ApplicationFrm : Form
    {
        FileHandler handler = new FileHandler();
        Validation valid = new Validation();
        List<Student> students;
        int age = 0;
        string Studentno = "";
        public ApplicationFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationFrm_Load(object sender, EventArgs e)
        {
            //retrieve datatset with our databse tables from FileHandler
            dataGridView1.DataSource = handler.getStudents();
            students = handler.getStudents();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search method
            dataGridView1.DataSource = handler.Search(txtSearch.Text);
            txtSearch.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportFrm reportFrm = new ReportFrm();
            this.Hide();
            reportFrm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //implement validation
            if (valid.isInteger(txtAge.Text))
            {
                if ((!(valid.isEmpty(txtStudentId.Text, txtNameSurname.Text, cmbCourse.Text))) || (!valid.validAge(Convert.ToInt32(txtAge.Text))) || (!valid.uniqueID(txtStudentId.Text, handler.getStudents())))
                {

                }
                else
                {
                    handler.AddNewStudent(new Student(txtStudentId.Text, txtNameSurname.Text, Convert.ToInt32(txtAge.Text), cmbCourse.Text));
                    LoadData();
                    ClearFields();
                }
            }
            else
            {
                ClearFields();
            }
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!valid.isInteger(txtAge.Text))
            {
                
            }
            else
            {
                age = Convert.ToInt32(txtAge.Text);
            }

            // Find the student by the entered StudentId
            var studentToUpdate = students.FirstOrDefault(s => s.StudentId == txtStudentId.Text);

            if (studentToUpdate == null)
            {
                MessageBox.Show("Student with the specified ID does not exist.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the update
            var confirmResult = MessageBox.Show("Are you sure you want to update this student record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            // Create the updated student object
            Student updatedStudent = new Student(txtStudentId.Text, txtNameSurname.Text, age, cmbCourse.Text);

            // Update the student record
            handler.UpdateStudent(updatedStudent, txtStudentId.Text);
            MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the data and clear input fields
            LoadData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validate that the StudentId field is not empty
            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                MessageBox.Show("Please enter a Student ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the StudentId from the textbox
            string studentId = txtStudentId.Text.Trim();

            try
            {

                // Check if the student exists
                var studentToDelete = students.FirstOrDefault(s => s.StudentId == studentId);

                if (studentToDelete == null)
                {
                    MessageBox.Show("Student with the specified ID does not exist.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm the deletion
                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the student record with ID: {studentId}? This action cannot be undone.",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.No)
                {
                    return;
                }

                // Delete the student record
                handler.DeleteStudent(studentId);
                MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data and clear input fields
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = handler.getStudents();
            txtSearch.Clear();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //extract selected row information into the respective inputs

            txtStudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNameSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAge.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbCourse.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            btnUpdate.Enabled = true;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To update records please double click on the row of data that you would like to edit and make your changes in the provided input boxes.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            txtNameSurname.Clear(); txtAge.Text = "0"; txtStudentId.Clear(); cmbCourse.Text = " ";
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = handler.getStudents();
        }
    }
}
