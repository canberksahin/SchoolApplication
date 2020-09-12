namespace SchoolApplication.Migrations
{
    using SchoolApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolApplication.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolApplication.Models.SchoolContext context)
        {
            //Every database will be seeded only once
            if (!context.Grades.Any())
            {
                IList<Grade> defaultGrades = new List<Grade>();
                Grade grade1 = new Grade() { GradeNumber = 1, Section = "A" };
                defaultGrades.Add(grade1);


                IList<Course> defaultCourses = new List<Course>();
                Course course1 = new Course() { Name = "Math", Students = new List<Student>() };
                Course course2 = new Course() { Name = "Science", Students = new List<Student>() };
                Course course3 = new Course() { Name = "Computer", Students = new List<Student>() };
                defaultCourses.Add(course1);
                defaultCourses.Add(course2);
                defaultCourses.Add(course3);

                Student student = new Student { StudentName = "John Doe", Courses = (List<Course>)defaultCourses };

                context.Courses.AddRange(defaultCourses);
                context.Students.Add(student);
                context.Grades.Add(grade1);
            }

            base.Seed(context);
        }
    }
}
