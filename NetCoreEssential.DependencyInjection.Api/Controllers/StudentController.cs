using Microsoft.AspNetCore.Mvc;
using NetCoreEssential.DependencyInjection.Api.IServices;

namespace NetCoreEssential.DependencyInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService studentService)
        {
            _service = studentService;
       }

        public IActionResult GetAll()
        {
            var students = _service.GetAll();
            return Ok(students);
        }

        [HttpGet("identifier")]
        public IActionResult GetIdentifier()
        {
            return Ok(_service.GetIdentifier());
        }
    }
}