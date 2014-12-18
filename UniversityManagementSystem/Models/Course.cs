using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please enter a unique course code.")]
        [Remote("IsCodeExists", "Course", ErrorMessage = "Course code already exists.")]
        public string Code { get; set; }

        [Range(1, 6, ErrorMessage = "Course credit must be between 1 and 6")]
        public int Credit { get; set; }

        [Required(ErrorMessage = "Please enter a unique course name.")]
        [Remote("IsNameExists", "Course", ErrorMessage = "Course name already exists.")]
        public string Name { get; set; }

        public string Description { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }

        
    }
}