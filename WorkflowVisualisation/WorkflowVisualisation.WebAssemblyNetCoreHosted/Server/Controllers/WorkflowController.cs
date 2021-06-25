using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowVisualisation.WebAssemblyNetCoreHosted.Server.DBContext;
using WorkflowVisualisation.WebAssemblyNetCoreHosted.Shared;

namespace WorkflowVisualisation.WebAssemblyNetCoreHosted.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkflowController : ControllerBase
    {

        private readonly ILogger<WorkflowController> _logger;
        private WorkflowContext _context;

        public WorkflowController(ILogger<WorkflowController> logger, WorkflowContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Workflow> Get()
        {
            return _context.Workflows;
        }
    }
}
