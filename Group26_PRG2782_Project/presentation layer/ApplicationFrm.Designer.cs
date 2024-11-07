using System.Windows.Forms;

namespace Student_Mangement_Application.Presentation_Layer
{
    partial class ApplicationFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPreviousFrm = new System.Windows.Forms.Button();
            this.grbInformationEditor = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbInformationEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(60, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(772, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(164)))), ((int)(((byte)(242)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(142, 533);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 38);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Add New Student";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(164)))), ((int)(((byte)(242)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(365, 533);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 38);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(164)))), ((int)(((byte)(242)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(566, 533);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 38);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPreviousFrm
            // 
            this.btnPreviousFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnPreviousFrm.FlatAppearance.BorderSize = 0;
            this.btnPreviousFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousFrm.Location = new System.Drawing.Point(816, 586);
            this.btnPreviousFrm.Name = "btnPreviousFrm";
            this.btnPreviousFrm.Size = new System.Drawing.Size(102, 29);
            this.btnPreviousFrm.TabIndex = 14;
            this.btnPreviousFrm.Text = "View Report";
            this.btnPreviousFrm.UseVisualStyleBackColor = false;
            this.btnPreviousFrm.Click += new System.EventHandler(this.button4_Click);
            // 
            // grbInformationEditor
            // 
            this.grbInformationEditor.Controls.Add(this.label8);
            this.grbInformationEditor.Controls.Add(this.cmbGender);
            this.grbInformationEditor.Controls.Add(this.txtPhone);
            this.grbInformationEditor.Controls.Add(this.label7);
            this.grbInformationEditor.Controls.Add(this.txtImage);
            this.grbInformationEditor.Controls.Add(this.label3);
            this.grbInformationEditor.Controls.Add(this.txtNameSurname);
            this.grbInformationEditor.Controls.Add(this.label2);
            this.grbInformationEditor.Location = new System.Drawing.Point(55, 357);
            this.grbInformationEditor.Name = "grbInformationEditor";
            this.grbInformationEditor.Size = new System.Drawing.Size(777, 164);
            this.grbInformationEditor.TabIndex = 15;
            this.grbInformationEditor.TabStop = false;
            this.grbInformationEditor.Text = "Insert Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Module Code";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbGender.Location = new System.Drawing.Point(639, 73);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(104, 21);
            this.cmbGender.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(112, 31);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(64, 20);
            this.txtPhone.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Student Id";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(373, 73);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(137, 20);
            this.txtImage.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(113, 74);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(137, 20);
            this.txtNameSurname.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(579, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(747, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 19);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(128)))), ((int)(((byte)(238)))));
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(60, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 22);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset database";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(128)))), ((int)(((byte)(238)))));
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Location = new System.Drawing.Point(726, 325);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(106, 22);
            this.btnInformation.TabIndex = 41;
            this.btnInformation.Text = "Help";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(128)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(183, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 22);
            this.button1.TabIndex = 45;
            this.button1.Text = "View Modules Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Hans", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(264, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 31);
            this.label4.TabIndex = 46;
            this.label4.Text = "Student Management Form";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ApplicationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 627);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grbInformationEditor);
            this.Controls.Add(this.btnPreviousFrm);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApplicationFrm";
            this.Text = "ApplicationFrm";
            this.Load += new System.EventHandler(this.ApplicationFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbInformationEditor.ResumeLayout(false);
            this.grbInformationEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnPreviousFrm;
        private GroupBox grbInformationEditor;
        private Label label8;
        private ComboBox cmbGender;
        private TextBox txtImage;
        private Label label3;
        private TextBox txtNameSurname;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnReset;
        private Button btnInformation;
        private Button button1;
        private TextBox txtPhone;
        private Label label7;
        private Label label4;
    }
}