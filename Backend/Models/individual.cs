using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INvasjonNorge.API.Models
{
    public class individual
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String surname { get; set;}
        public String gender { get; set; }
        public DateTime MeetingDate { get; set; }

    }
}


