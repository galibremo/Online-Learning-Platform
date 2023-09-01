using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FeedbackDTO
    {
        public int id { get; set; }

        public int cid { get; set; }

        public int sid { get; set; }
        public string message { get; set; }
        public int rating { get; set; }
    }
}
