using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]//allows the app to specify primary key (contd.)
        [Display(Name = "Number")]                       //rather than have the database generate it 
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        
        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }//any number of students can be enrolled
        public ICollection<Instructor> Instructors { get; set; }//can be taught by multiple instructors
    }
}