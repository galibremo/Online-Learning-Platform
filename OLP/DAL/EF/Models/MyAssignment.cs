using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class MyAssignment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        [ForeignKey("teacher")]
        public int TsrId { get; set; }
        [ForeignKey("course")]
        public int CrsId { get; set; }
        [ForeignKey("student")]
        public int StuId { get; set; }
        [DefaultValue("ongoing")]
        [Required]
        [StringLength(20)]
        public string Status { get; set; }
        public virtual Student student { get; set; }
        public virtual Teacher teacher { get; set; }
        public virtual Course course { get; set; }
        public virtual ICollection<MySubmission> submissions { get; set; }
        public MyAssignment()
        {
            submissions = new List<MySubmission>();
        }
    }
}