using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admTarea12.Models
{
    public class Course
    {
        [Display(Name = "Numero")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 10)]
        public int Credits { get; set; }

        // NAVIGATION PROPERTIES
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}