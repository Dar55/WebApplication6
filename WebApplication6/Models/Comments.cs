using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Comments
    {

        public int Id { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
        public string Dates { get; set; }
        public string IdComment { get; set; }
        public string Like { get; set; }
        public string Gender { get; set; }

    }
}