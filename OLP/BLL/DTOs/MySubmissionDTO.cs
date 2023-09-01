using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MySubmissionDTO
    {
        public int Id { get; set; }
        public DateTime SubmitDate { get; set; }
        public string CourseContent { get; set; }
        public string Status { get; set; }
        public int AssId { get; set; }
        public int StuId { get; set; }
    }
}