using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required, MaxLength(20,ErrorMessage ="Student name can not be more than 20 characters."),]
        public string StudentName { get; set; }


        public List<Course> Courses { get; set; }

    }
}
