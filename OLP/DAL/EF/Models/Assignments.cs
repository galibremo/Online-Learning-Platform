using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Assignments
    {

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime deadline { get; set; }
        [ForeignKey("teacher")]
        public int tid { get; set; }
        [ForeignKey("course")]
        public int cid { get; set; }
        [DefaultValue("Active")]
        [StringLength(100)]
        public string status { get; set; }
        public virtual Teacher teacher { get; set; }
        public virtual Course course { get; set; }
        public virtual ICollection<Submission> submissions { get; set; }
        public Assignments()
        {
            submissions = new List<Submission>();
        }
    }
}
