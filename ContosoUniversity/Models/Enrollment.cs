using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }//primary key
        public int CourseID { get; set; }//foreign key, corresponds to Course
        public int StudentID { get; set; }//foreign key, corresponds to Student
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; } //Grade=enum, ?=grade property is nullable. Null grade=grade unknown/unassigned

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}