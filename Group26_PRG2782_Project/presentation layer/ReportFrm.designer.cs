using System.Windows.Forms;

namespace Student_Mangement_Application.Presentation_Layer
{
    partial class ReportFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreviousFrm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotStudents = new System.Windows.Forms.TextBox();
            this.lblTotStudents = new System.Windows.Forms.Label();
            this.lblAvgAge = new System.Windows.Forms.Label();
            this.txtAvgAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPreviousFrm
            // 
            this.btnPreviousFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnPreviousFrm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviousFrm.Location = new System.Drawing.Point(602, 425);
            this.btnPreviousFrm.Name = "btnPreviousFrm";
            this.btnPreviousFrm.Size = new System.Drawing.Size(121, 29);
            this.btnPreviousFrm.TabIndex = 21;
            this.btnPreviousFrm.Text = "back to Database";
            this.btnPreviousFrm.UseVisualStyleBackColor = false;
            this.btnPreviousFrm.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(256, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 31);
            this.label4.TabIndex = 24;
            this.label4.Text = "Report Form";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotStudents
            // 
            this.txtTotStudents.Location = new System.Drawing.Point(292, 163);
            this.txtTotStudents.Name = "txtTotStudents";
            this.txtTotStudents.Size = new System.Drawing.Size(209, 20);
            this.txtTotStudents.TabIndex = 25;
            // 
            // lblTotStudents
            // 
            this.lblTotStudents.AutoSize = true;
            this.lblTotStudents.Location = new System.Drawing.Point(142, 166);
            this.lblTotStudents.Name = "lblTotStudents";
            this.lblTotStudents.Size = new System.Drawing.Size(124, 13);
            this.lblTotStudents.TabIndex = 26;
            this.lblTotStudents.Text = "Total number of students";
            this.lblTotStudents.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAvgAge
            // 
            this.lblAvgAge.AutoSize = true;
            this.lblAvgAge.Location = new System.Drawing.Point(142, 220);
            this.lblAvgAge.Name = "lblAvgAge";
            this.lblAvgAge.Size = new System.Drawing.Size(126, 13);
            this.lblAvgAge.TabIndex = 28;
            this.lblAvgAge.Text = "Average Age of Students";
            // 
            // txtAvgAge
            // 
            this.txtAvgAge.Location = new System.Drawing.Point(292, 217);
            this.txtAvgAge.Name = "txtAvgAge";
            this.txtAvgAge.Size = new System.Drawing.Size(209, 20);
            this.txtAvgAge.TabIndex = 27;
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 466);
            this.Controls.Add(this.lblAvgAge);
            this.Controls.Add(this.txtAvgAge);
            this.Controls.Add(this.lblTotStudents);
            this.Controls.Add(this.txtTotStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPreviousFrm);
            this.Name = "ReportFrm";
            this.Text = "LoginFrm";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPreviousFrm;
        private Label label4;
        private TextBox txtTotStudents;
        private Label lblTotStudents;
        private Label lblAvgAge;
        private TextBox txtAvgAge;
    }
}