using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Feedback
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("courses")]
        public int cid { get; set; }
        [ForeignKey("students")]
        public int sid { get; set; }
        [Required]
        [StringLength(100)]
        public string message { get; set; }
        [Required]
        [Range(0, 5)]
        public int rating { get; set; }
        public virtual Student students { get; set; }
        public virtual Course courses { get; set; }
    }
}
