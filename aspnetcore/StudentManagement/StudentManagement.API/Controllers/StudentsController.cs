using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.API.Controllers
{
    // my url will be https://localhost:<port number>/api/students 
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Mark", "Jane", "Alex", "David" };
            return Ok(studentNames);
            
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            string[] studentNames = new string[] { "John", "Mark", "Jane", "Alex", "David" };
            string studentName = studentNames[id];


            if (studentName.Length > 0)
            {
                var response = new
                {
                    result = studentName,
                    message = "Student found"
                };
                return Ok(response);
            }
            else
            {
                var response = new
                {
                    result = new List<string>(),
                    message = "Name not found"
                };
                return Ok(response);
            }
             
        }
    }
}
