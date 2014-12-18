using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Code { get; set; }

        public int Credit { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }

        
    }
}