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
        //BindingSource src = new BindingSource();
        List<Student> students;
        string Studentno = "";
        public ApplicationFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Studentno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationFrm_Load(object sender, EventArgs e)
        {
            //retrieve datatset with our databse tables from FileHandler
            students = handler.getData();
            dataGridView1.DataSource = students;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            if ((!(valid.isEmpty(txtStudentId.Text, txtNameSurname.Text, Convert.ToInt32(txtAge.Text), cmbCourse.Text))) || (!valid.validAge(Convert.ToInt32(txtAge.Text))) || (!valid.uniqueID(txtStudentId.Text, handler.getData())))
            {
                
            }
            else
            {
                handler.AddNewStudent(new Student(txtStudentId.Text, txtNameSurname.Text, Convert.ToInt32(txtAge.Text), cmbCourse.Text));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = handler.getData();
            }
            txtNameSurname.Clear(); txtAge.Text = "0"; txtStudentId.Clear(); cmbCourse.Text = " ";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //handler.Update(new Student(txtStudentId.Text, txtNameSurname.Text, Convert.ToInt32(txtAge.Text), cmbCourse.Text), Studentno);
            txtNameSurname.Clear(); txtAge.Text = "0"; txtStudentId.Clear(); cmbCourse.Text = " ";
            dataGridView1.DataSource = handler.getData();
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*string Studentno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            handler.Delete(Studentno);
            dataGridView1.DataSource = handler.getData();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = handler.getData();
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
    }
}
