using SchoolApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SchoolApplication
{
    // TODO: App.Config ConnectionString need update according to database connection parameters
    public partial class Form1 : Form
    {
        SchoolContext db = new SchoolContext();
        public Form1()
        {
            InitializeComponent();

            //Grades-Section Combobox values
            string[] grades = { "A", "B", "C", "D" };
            cmbSection.DataSource = grades;

            #region Data Source of the DataGridViews
            dgvGrades.DataSource = db.Grades.ToList();

            dgvStudents.DataSource = db.Students.Select(o => new
            { ID = o.StudentID, Name = o.StudentName }).ToList();

            dgvCourses.DataSource = db.Courses.Select(o => new
            { Name = o.Name }).ToList(); 
            #endregion
        }

        private async void btnAddCourse_Click(object sender, EventArgs e)
        {
            decimal gradeNumber = nudGradeNumber.Value;
            string section = cmbSection.SelectedItem.ToString();

            Grade grade = new Grade { Section = section, GradeNumber = gradeNumber };
            db.Grades.Add(grade);
            await db.SaveChangesAsync();

            // this code is added to refresh the datagridview after adding
            dgvGrades.DataSource = db.Grades.ToList();

            MessageBox.Show("Grade is added successfully");

            //clear NumericUpDown and ComboBox
            nudGradeNumber.Value = 1;
            cmbSection.SelectedIndex = 0;
        }

        private void dgvGrades_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Grade grade = new Grade { Section = dgvGrades.SelectedRows[0].Cells[2].Value.ToString(), GradeNumber = Convert.ToDecimal(dgvGrades.SelectedRows[0].Cells[1].Value.ToString()), GradeId = ( (int)dgvGrades.SelectedRows[0].Cells[0].Value  )};
            GradeUpdate frm = new GradeUpdate(grade);
            frm.ShowDialog();

            // this code is added to refresh the datagridview after delete
            dgvGrades.DataSource = db.Grades.ToList();
        }
    }
}
