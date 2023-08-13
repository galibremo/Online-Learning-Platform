using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Student_Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public virtual ICollection<MyCourse> MyCourses { get; set; }
        public Student() 
        {
            MyCourses = new List<MyCourse>();
        }
    }
}
