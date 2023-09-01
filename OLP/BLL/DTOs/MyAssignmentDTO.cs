using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MyAssignmentDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public int TsrId { get; set; }
        public int StuId { get; set; }
        public string Status { get; set; }
        public int CrsId { get; set; }
    }
}