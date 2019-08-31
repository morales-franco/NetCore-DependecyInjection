using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreEssential.DependencyInjection.Api.IServices;

namespace NetCoreEssential.DependencyInjection.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreeterController : ControllerBase
    {
        private readonly IGreeterService _greeterService;

        public GreeterController(IGreeterService greeterService)
        {
            _greeterService = greeterService;
        }

        public IActionResult Get()
        {
            return Ok(_greeterService.GetGreeting());
        } 
    }
}