using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public int NumOfActvCrs { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}