using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DevAzureManager.Clients;
using DevAzureManager.Models;
using DevAzureManager.Models.Azure;
using Microsoft.AspNetCore.Mvc;

namespace DevAzureManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReleaseController : ControllerBase
    {
        private readonly IReleaseClient _releaseClient;
        private readonly IMapper _mapper;

        public ReleaseController(IReleaseClient releaseClient,
            IMapper mapper)
        {
            _mapper = mapper;
            _releaseClient = releaseClient;
        }

        [HttpGet]
        [Route("approvals")]
        public async Task<ActionResult<ApprovalsPendingCountDto>> Approvals(
            Status? status = null)
        {
            var approvals = await _releaseClient.GetApprovalPendingAsync(status ?? Status.Pending);
            return Ok(_mapper.Map<ApprovalsPendingCountDto>(approvals));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ReleaseDetailDto>> Approvals([FromRoute]long id)
        {
            var detail = await _releaseClient.GetReleaseDetail(id).ConfigureAwait(false);
            return Ok(_mapper.Map<ReleaseDetailDto>(detail));
        }

        [HttpPost]
        [Route("approvals/{user}/{token}")]
        public async Task<ActionResult> Approve([FromBody] List<ApprovalsRequestDto> approves)
        {
            foreach (var approva in approves)
            {
                await _releaseClient.PostApprovalPendingAsync(approva.Id,
                    new ApprovalsRequestVSTSDto()
                    {
                        Comments = approva.Comments,
                        Status = approva.Status
                    });
            }
            return Ok();
        }
    }


}
