using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Course
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateTime created { get; set; }
        public string description { get; set; }
        [ForeignKey("teacher")]
        public int tid { get; set; }
        public virtual Teacher teacher { get; set; }
    }
}
