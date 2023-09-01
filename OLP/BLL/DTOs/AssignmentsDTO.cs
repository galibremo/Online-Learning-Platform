using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AssignmentsDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime deadline { get; set; }

        public int tid { get; set; }

        public int cid { get; set; }
        public string status { get; set; }

    }
}