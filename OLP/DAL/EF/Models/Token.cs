using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Token
    {
        [Key]
        public int id { get; set; }
        public string key { get; set; }
        public DateTime created { get; set; }
        public DateTime expiredDate { get; set; }
        [ForeignKey("Admin")]
        public int aid { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
