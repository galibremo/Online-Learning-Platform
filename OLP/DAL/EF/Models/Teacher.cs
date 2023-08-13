using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        [DefaultValue("teacher")]
        public string type { get; set; }
        public virtual ICollection<Course> courses { get; set; }
        public Teacher()
        {
            courses = new List<Course>();
        }
    }
}
