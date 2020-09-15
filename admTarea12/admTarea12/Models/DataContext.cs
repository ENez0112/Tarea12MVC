using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace admTarea12.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admTarea12.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<admTarea12.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<admTarea12.Models.Enrollment> Enrollments { get; set; }
    }
}