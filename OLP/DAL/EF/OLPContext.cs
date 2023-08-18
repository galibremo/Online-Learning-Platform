using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class OLPContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }    
        public virtual DbSet<MyCourse> MyCourses { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<MyAssignment> MyAssignments { get; set; }
        public virtual DbSet<MySubmission> MySubmissions { get; set;}
        public virtual DbSet<Contents> Contents { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<WatchList> WatchLists { get; set; }
    }
}
