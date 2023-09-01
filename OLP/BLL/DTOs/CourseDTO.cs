using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CourseDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime created { get; set; }
        public string description { get; set; }

        public int tid { get; set; }
    }
}