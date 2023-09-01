using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WatchListDTO
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }
        public string ContentTitle { get; set; }
        public string ContentStatus { get; set; }
        public int StuId { get; set; }
        public int CntId { get; set; }
        public int CrsId { get; set; }
        public int MyCrsId { get; set; }
    }
}
