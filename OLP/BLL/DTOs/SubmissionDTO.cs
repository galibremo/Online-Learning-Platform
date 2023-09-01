using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SubmissionDTO
    {
        public int id { get; set; }
        public DateTime submitDate { get; set; }
        public string content { get; set; }

        public int aid { get; set; }

        public int sid { get; set; }
        public int marks { get; set; }
    }
}