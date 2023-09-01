using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Submission
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime submitDate { get; set; }
        public string content { get; set; }
        [ForeignKey("assignments")]
        public int aid { get; set; }
        [ForeignKey("students")]
        public int sid { get; set; }
        public int marks { get; set; }
        public virtual Student students { get; set; }
        public virtual Assignments assignments { get; set; }
    }
}
