using System.Collections.Generic;
using    LTM.School.Application.enumsType;
namespace LTM.School.Core.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public CourseGrade Grade { get; set; }

        public ICollection <Enrollment>  Enrollments{ get; set; }
    }
}