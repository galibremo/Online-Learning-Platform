using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLP.Models
{
    public class StudentLoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}