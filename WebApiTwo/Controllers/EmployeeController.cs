using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTwo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            List<Employee> employeeLsit = new List<Employee>();

            employeeLsit.Add(new Employee { Address = "Delhi", Id = 1, Name = "Yuvraj" });
            employeeLsit.Add(new Employee { Address = "Shimla", Id = 2, Name = "Aman" });
            employeeLsit.Add(new Employee { Address = "Gurgaon", Id = 3, Name = "Parvaan" });
            employeeLsit.Add(new Employee { Address = "Mumbai", Id = 4, Name = "Pinki" });
            employeeLsit.Add(new Employee { Address = "Calcutta", Id = 5, Name = "Vikas" });

            return employeeLsit;
        }
    }
}