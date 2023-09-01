using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenAdminDTO
    {
        public int id { get; set; }
        public string key { get; set; }
        public DateTime created { get; set; }
        public DateTime expiredDate { get; set; }

        public int aid { get; set; }
    }
}
