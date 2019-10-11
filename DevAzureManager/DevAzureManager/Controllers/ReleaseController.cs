using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevAzureManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReleaseController : ControllerBase
    {
        private readonly ILogger<ReleaseController> _logger;

        public ReleaseController(ILogger<ReleaseController> logger)
        {
            _logger = logger;
        }

    }
}
