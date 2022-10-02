using BlogApi.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using (var c = new Context())
            {

                var values = c.Employees.ToList();
                return Ok(values); 
            }

             
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee p)
        {
            using (var c =new Context())
            {
                c.Add(p);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            using(var c = new Context())
            {
                var value= c.Employees.Find(id);
                if (value == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(value);
                }
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            using (var c = new Context())
            {
                var value = c.Employees.Find(id);
                if (value == null)
                {
                    return NotFound();
                }
                else
                {
                    c.Remove(value);
                    c.SaveChanges();
                    return Ok();
                }
            }
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee emp)
        {
            using (var c = new Context())
            {
                var value = c.Find<Employee>(emp.EmployeeID);
                if (value == null)
                {
                    return NotFound();
                }
                else
                {
                    value.EmployeeName = emp.EmployeeName;
                    c.SaveChanges();
                    return Ok();
                }
            }
        }
    }
}
