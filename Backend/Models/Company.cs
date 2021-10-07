using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace INvasjonNorge.API.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Advisor { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string MeetingDate { get; set; }

        public string Subscriber { get; set; }

        public bool IsAvailable { get; set; }


        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }

        public string Smith { get; internal set; }

    }
}

