using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INvasjonNorge.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace INvasjonNorge.API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class individualsController : ControllerBase
    {
        List<individual> individuals = new List<individual>()
     {
         new individual()
         {
             Id=1,
             Name="ben",
             surname="Noah",
             gender="Female",
             MeetingDate= new DateTime(2021, 1, 12)
         },
            new individual()
         {
             Id=2,
             Name="Jane",
             surname="Noah",
             gender="Female",
             MeetingDate= new DateTime(2021, 11, 12)
         },
                  new individual()
         {
             Id=3,
             Name="Jane",
             surname="Noah",
             gender="Female",
             MeetingDate= new DateTime(2021, 11, 12)
         },
                  new individual()
         {
             Id=4,
             Name="Jane",
             surname="Noah",
             gender="Female",
             MeetingDate= new DateTime(2021, 11, 12)
         },
                  new individual()
         {
             Id=5,
             Name="Jane",
             surname="Noah",
             gender="Female",
             MeetingDate= new DateTime(2021, 11, 12)
         },
     };
        public IEnumerable<individual> GetStudents()
        {
            return individuals;
        }


    }
}
