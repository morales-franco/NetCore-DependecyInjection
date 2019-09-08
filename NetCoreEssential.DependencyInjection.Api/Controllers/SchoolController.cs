using Microsoft.AspNetCore.Mvc;
using NetCoreEssential.DependencyInjection.Api.IServices;

namespace NetCoreEssential.DependencyInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _service;
        private readonly IBestTeacherService _bestTeacherService;
        public SchoolController(ISchoolService schoolService,
            IBestTeacherService bestTeacherService)
        {
            _service = schoolService;
            _bestTeacherService = bestTeacherService;
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

        [HttpGet("publickey")]
        public IActionResult GetPublicKey()
        {
            return Ok(_service.GetPublicKey());
        }

        [HttpGet("bestteacher")]
        public IActionResult GetBestTeacher()
        {
            return Ok(_bestTeacherService.GetBestTeacher());
        }
    }
}