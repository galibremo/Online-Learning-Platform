using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Contents
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime created { get; set; }
        [ForeignKey("courses")]
        public int cid { get; set; }
        public virtual Course courses { get; set; }
        public virtual ICollection<WatchList> WatchLists { get; set; }
        public Contents()
        {
            WatchLists = new List<WatchList>();
        }


    }
}
