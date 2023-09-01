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
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Contents> Contents { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollments> Enrollments { get; set; }
        public virtual DbSet<MyAssignment> MyAssignments { get; set; }
        public virtual DbSet<MyCourse> MyCourses { get; set; }
        public virtual DbSet<MySubmission> MySubmissions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<TokenTeacher> TokenTeachers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TokenStudent> TokenStudents { get; set; }
        public virtual DbSet<WatchList> WatchLists { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }

    }
}