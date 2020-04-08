using System.Threading.Tasks;
using AutoMapper;
using DevAzureManager.Clients;
using DevAzureManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DevAzureManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReleaseController : ControllerBase
    {
        private readonly ILogger<ReleaseController> _logger;
        private readonly IReleaseClient _releaseClient;
        private readonly IMapper _mapper;

        public ReleaseController(ILogger<ReleaseController> logger,
            IReleaseClient releaseClient,
            IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _releaseClient = releaseClient;
        }

        [HttpGet]
        [Route("approvals")]
        public async Task<ActionResult<ApprovalsPendingCountDto>> Approvals(
            StatusRelease? status = null)
        {
            var approvals = await _releaseClient.GetApprovalPendingAsync(status ?? StatusRelease.pending);
            return Ok(_mapper.Map<ApprovalsPendingCountDto>(approvals));
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ReleaseDetailDto>> Approvals([FromRoute]long id)
        {
            var detail = await _releaseClient.GetReleaseDetail(id).ConfigureAwait(false);
            return Ok(_mapper.Map<ReleaseDetailDto>(detail));
        }
    }


}
