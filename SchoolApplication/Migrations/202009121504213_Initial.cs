namespace SchoolApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeNumber = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_StudentID = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentID, t.Course_Id })
                .ForeignKey("dbo.Students", t => t.Student_StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Student_StudentID)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_StudentID", "dbo.Students");
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Student_StudentID" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.Grades");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
