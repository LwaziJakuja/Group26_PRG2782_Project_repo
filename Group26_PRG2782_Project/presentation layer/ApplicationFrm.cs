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
        BindingSource src;
        string Studentno = "";
        public ApplicationFrm()
        {
            InitializeComponent();
            
            //adding all existing Module Codes from Modules tbl into ModuleCodes combobox list
            //cmbCourse.DataSource = handler.getCourseCodes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Studentno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("The student no is: " + Studentno);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationFrm_Load(object sender, EventArgs e)
        {
            //retrieve datatset with our databse tables from DataHandler
            dataGridView1.DataSource = handler.getData();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = handler.Search(txtSearch.Text);
            btnReset.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportFrm reportFrm = new ReportFrm();
            this.Hide();
            reportFrm.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!(valid.isEmpty(txtStudentId.Text, txtNameSurname.Text, Convert.ToInt32(txtAge.Text), cmbCourse.Text)))
            {
                MessageBox.Show("Cannot insert new details! Please make sure to fill in all necessary fileds before going further.");
            }
            else
            {
                handler.AddNewStudent(new Student(txtStudentId.Text, txtNameSurname.Text, Convert.ToInt32(txtAge.Text), cmbCourse.Text));
                dataGridView1.DataSource = handler.getData();
            }
            txtNameSurname.Clear(); txtAge.Clear(); txtStudentId.Clear(); cmbCourse.Text = " ";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate the input fields
            string errorMessage = valid.ValidateInput(txtStudentId.Text, txtNameSurname.Text, txtAge.Text, cmbCourse.Text);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse the age safely
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Invalid age. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the list of students
            var existingStudents = handler.GetAllStudents();

            // Find the student by the entered StudentId
            var studentToUpdate = existingStudents.FirstOrDefault(s => s.StudentId == txtStudentId.Text);

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
            /*string Studentno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            handler.Delete(Studentno);
            dataGridView1.DataSource = handler.getData();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
             dataGridView1.DataSource = handler.getData();
             txtSearch.Clear();
             btnReset.Enabled = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //extract selected row information into the respective inputs
            /*txtNameSurname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtImage.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            birthDatePicker.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            cmbGender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cmbModuleCodes.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            btnUpdate.Enabled = true;*/
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
    }
}
