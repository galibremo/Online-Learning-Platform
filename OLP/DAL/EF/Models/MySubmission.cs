using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DAL.EF.Models
{
    public class MySubmission
    {
        public int Id { get; set; }
        [Required]
        public DateTime SubmitDate { get; set; }
        [Required]
        [StringLength(100)]
        public string CourseContent { get; set; }
        [ForeignKey("assignments")]
        public int AssId { get; set; }
        [DefaultValue("Submitted")]
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [ForeignKey("students")]
        public int StuId { get; set; }
        public virtual Student students { get; set; }
        public virtual MyAssignment assignments { get; set; }
    }
}