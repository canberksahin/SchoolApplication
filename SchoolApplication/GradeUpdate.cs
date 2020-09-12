using SchoolApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApplication
{
    public partial class GradeUpdate : Form
    {
        SchoolContext db = new SchoolContext();
        Grade grade1;
        public GradeUpdate(Grade grade)
        {
            InitializeComponent();
            grade1 = grade;
            //Grades-Section Combobox values
            string[] grades = { "A", "B", "C", "D" };
            cmbSection.DataSource = grades;

            cmbSection.SelectedItem = grade.Section;
            nudGradeNumber.Value = grade.GradeNumber;
        }

        private async void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            Grade updateGrade = db.Grades.SingleOrDefault(x => x.GradeId == grade1.GradeId);
            updateGrade.GradeNumber = nudGradeNumber.Value;
            updateGrade.Section = cmbSection.SelectedItem.ToString();
            await db.SaveChangesAsync();
            MessageBox.Show("Grade is updated succesfully");
            this.Close();

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Grade removeGrade = db.Grades.SingleOrDefault(x => x.GradeId == grade1.GradeId);
            db.Grades.Remove(removeGrade);
            await db.SaveChangesAsync();
            MessageBox.Show("Grade is deleted succesfully");
            this.Close();
        }
    }
}
