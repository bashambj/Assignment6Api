using Assignment6.Models;
using Assignment6Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Assignment6.AddControllers
{
    [ApiController]
    [Route("[controller]")]
    public class Assignment6Controller : ControllerBase
    {
        private ILogger<Assignment6Controller> _logger;

        private Assignment6ApiContext _context;
        public Assignment6Controller(ILogger<Assignment6Controller> logger, Assignment6ApiContext context)
        {
            _logger = logger;
            _context = context;
        }
         [HttpGet]
        public Assignment6Names Get() 
        {
            return new Assignment6Names
            {
                firstName = "Brady",
                lastName = "Basham",
                major = "Software Development"
            };
        }

    }
}