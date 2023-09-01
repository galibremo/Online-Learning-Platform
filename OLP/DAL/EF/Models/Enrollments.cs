using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Enrollments
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("students")]
        public int sid { get; set; }
        [ForeignKey("teachers")]
        public int tid { get; set; }
        [ForeignKey("courses")]
        public int cid { get; set; }
        public virtual Teacher teachers { get; set; }
        public virtual Course courses { get; set; }
        public virtual Student students { get; set; }

    }
}