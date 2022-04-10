using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Linq;
using API.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly DataContext _context;

        public EmployeesController(DataContext context)
        {
            _context = context;


        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees(){

                var emplist = _context.Employee.ToListAsync();
                return  await emplist;

        }


        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id){

                var emprecord = _context.Employee.Find(id);
                return emprecord;

        }

    }
}