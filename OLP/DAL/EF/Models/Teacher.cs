using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [PasswordPropertyText(true)]
        public string password { get; set; }
        [DefaultValue("teacher")]
        public string type { get; set; }
        public virtual ICollection<Course> courses { get; set; }
        public virtual ICollection<Enrollments> enrollments { get; set; }
        public virtual ICollection<Assignments> assignments { get; set; }
        public virtual ICollection<TokenTeacher> tokenteacher { get; set; }
        public Teacher()
        {
            courses = new List<Course>();
            enrollments = new List<Enrollments>();
            assignments = new List<Assignments>();
            tokenteacher = new List<TokenTeacher>();
        }
    }
}
