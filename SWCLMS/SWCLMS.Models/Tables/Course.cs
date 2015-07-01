using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWCLMS.Models.Tables
{
    public class Course
    {
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public byte GradeLevel { get; set; }
        public byte IsArchived { get; set; }  //bit??
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
