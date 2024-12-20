﻿using Group26_PRG2782_Project.Business_logic_layer;
using Group26_PRG2782_Project.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mangement_Application.Presentation_Layer
{
    public partial class ReportFrm : Form
    {
        Report report;
        FileHandler handler = new FileHandler();
        public ReportFrm()
        {
            InitializeComponent();
        }

        private void LoginRegister_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            ApplicationFrm applicationFrm = new ApplicationFrm();
            this.Close();
            applicationFrm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            report = new Report(handler.getStudents());

            report.GenerateSummaryReport();

            txtTotStudents.Text = report.TotalStudents.ToString();
            txtAvgAge.Text = Math.Round(report.AverageAge, 4).ToString();
        }
    }
}
