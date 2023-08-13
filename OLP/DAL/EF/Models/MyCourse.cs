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
    public class MyCourse
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        public DateTime EnrDate { get; set; }
        [DefaultValue("Ongoing")]
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [ForeignKey("Student")]
        public int StuId { get; set; }
        public virtual Student Student { get; set; }    
    }
}
