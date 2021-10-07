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


    public class CompaniesController : ControllerBase
    {
        private readonly ShopContext _context;

        public CompaniesController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task <IActionResult> GetAllCompanies()
        {
            return Ok(await _context.Companies.ToArrayAsync());

        }

        [HttpGet("{id}")]
        public IActionResult GetCompany(int id)
        {
            var company = _context.Companies.Find(id);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);

        }



    }
}
