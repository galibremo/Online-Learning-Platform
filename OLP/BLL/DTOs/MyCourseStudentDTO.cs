using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MyCourseStudentDTO : MyCourseDTO
    {
        public StudentDTO Student { get; set; }
    }
}
