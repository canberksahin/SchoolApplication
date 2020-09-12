namespace SchoolApplication
{
    partial class Form1
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
            this.grbCourses = new System.Windows.Forms.GroupBox();
            this.grbStudents = new System.Windows.Forms.GroupBox();
            this.lblGradeNumber = new System.Windows.Forms.Label();
            this.nudGradeNumber = new System.Windows.Forms.NumericUpDown();
            this.lblSection = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.grbCourses.SuspendLayout();
            this.grbStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCourses
            // 
            this.grbCourses.Controls.Add(this.dgvGrades);
            this.grbCourses.Controls.Add(this.btnAddCourse);
            this.grbCourses.Controls.Add(this.cmbSection);
            this.grbCourses.Controls.Add(this.lblSection);
            this.grbCourses.Controls.Add(this.nudGradeNumber);
            this.grbCourses.Controls.Add(this.lblGradeNumber);
            this.grbCourses.Location = new System.Drawing.Point(12, 12);
            this.grbCourses.Name = "grbCourses";
            this.grbCourses.Size = new System.Drawing.Size(599, 130);
            this.grbCourses.TabIndex = 0;
            this.grbCourses.TabStop = false;
            this.grbCourses.Text = "Grades";
            // 
            // grbStudents
            // 
            this.grbStudents.Controls.Add(this.dgvStudents);
            this.grbStudents.Location = new System.Drawing.Point(12, 148);
            this.grbStudents.Name = "grbStudents";
            this.grbStudents.Size = new System.Drawing.Size(307, 145);
            this.grbStudents.TabIndex = 1;
            this.grbStudents.TabStop = false;
            this.grbStudents.Text = "Students";
            // 
            // lblGradeNumber
            // 
            this.lblGradeNumber.AutoSize = true;
            this.lblGradeNumber.Location = new System.Drawing.Point(27, 29);
            this.lblGradeNumber.Name = "lblGradeNumber";
            this.lblGradeNumber.Size = new System.Drawing.Size(36, 13);
            this.lblGradeNumber.TabIndex = 0;
            this.lblGradeNumber.Text = "Grade";
            // 
            // nudGradeNumber
            // 
            this.nudGradeNumber.Location = new System.Drawing.Point(81, 27);
            this.nudGradeNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGradeNumber.Name = "nudGradeNumber";
            this.nudGradeNumber.Size = new System.Drawing.Size(120, 20);
            this.nudGradeNumber.TabIndex = 1;
            this.nudGradeNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(20, 63);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(81, 60);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(121, 21);
            this.cmbSection.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(81, 88);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(121, 23);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(310, 9);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(283, 121);
            this.dgvGrades.TabIndex = 5;
            this.dgvGrades.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrades_CellMouseDoubleClick);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 16);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(301, 126);
            this.dgvStudents.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCourses);
            this.groupBox1.Location = new System.Drawing.Point(322, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courses";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(3, 16);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(283, 126);
            this.dgvCourses.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbStudents);
            this.Controls.Add(this.grbCourses);
            this.Name = "Form1";
            this.Text = "School Application";
            this.grbCourses.ResumeLayout(false);
            this.grbCourses.PerformLayout();
            this.grbStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCourses;
        private System.Windows.Forms.GroupBox grbStudents;
        private System.Windows.Forms.NumericUpDown nudGradeNumber;
        private System.Windows.Forms.Label lblGradeNumber;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCourses;
    }
}

