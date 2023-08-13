using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Contents
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateTime created { get; set; }
        [ForeignKey("courses")]
        public int cid { get; set; }
        public virtual Course courses { get; set; }
    }
}
