using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Course
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime created { get; set; }
        [Required]
        [StringLength(100)]
        public string description { get; set; }
        [ForeignKey("teacher")]
        public int tid { get; set; }

        public virtual Teacher teacher { get; set; }
        public virtual ICollection<Contents> contents { get; set; }
        public virtual ICollection<Enrollments> enrollments { get; set; }
        public virtual ICollection<Assignments> assignments { get; set; }
        public virtual ICollection<WatchList> WatchLists { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public Course()
        {
            contents = new List<Contents>();
            enrollments = new List<Enrollments>();
            assignments = new List<Assignments>();
            WatchLists = new List<WatchList>();
            Feedbacks = new List<Feedback>();
        }



    }
}
