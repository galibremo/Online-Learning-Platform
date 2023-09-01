using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class WatchList
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string CourseTitle { get; set; }
        [Required]
        [StringLength(20)]
        public string ContentTitle { get; set; }
        [Required]
        [StringLength(20)]
        public string ContentStatus { get; set; }
        [ForeignKey("Student")]
        public int StuId { get; set; }
        [ForeignKey("Contents")]
        public int CntId { get; set; }
        [ForeignKey("Course")]
        public int CrsId { get; set; }
        [ForeignKey("MyCourse")]
        public int MyCrsId { get; set; }
        public MyCourse MyCourse { get; set; }
        public Course Course { get; set; }
        public Contents Contents { get; set; }
        public Student Student { get; set; }
    }
}
