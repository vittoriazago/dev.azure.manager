using AutoMapper;
using DevAzureManager.Clients;
using DevAzureManager.Models;
using DevAzureManager.Models.Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevAzureManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReleasesController : ControllerBase
    {
        private readonly ILogger<ReleasesController> _logger;
        private readonly IReleaseClient _releaseClient;
        private readonly IMapper _mapper;

        public ReleasesController(ILogger<ReleasesController> logger,
            IReleaseClient releaseClient,
            IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _releaseClient = releaseClient;
        }

        /// <summary>
        /// Get releases pending approval by filters
        /// </summary>
        /// <param name="user"></param>
        /// <param name="token"></param>
        /// <param name="ambiente"></param>
        /// <param name="nomeAplicacao"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("approvals/{user}/{token}")]
        public async Task<ActionResult> Approvals(
            string user,
            string token,
            string ambiente = null,
            string nomeAplicacao = null,
            Status? status = null)
        {
            var approvals = await _releaseClient.GetApprovalPendingAsync(user, token, status);

            var approvalsDto = _mapper.Map<ApprovalsPendingCountDto>(approvals);
            ApplyFiltersInMemory(ambiente, nomeAplicacao, approvalsDto);

            approvalsDto.Count = approvalsDto.Value.Count();
            approvalsDto.Value = approvalsDto.Value.Select(a =>
            {
                var detail = _releaseClient.GetReleaseDetail(a.ReleaseId).Result;
                var detailDto = _mapper.Map<ReleaseDetailDto>(detail);
                a.Branch = detailDto.Branch;
                a.CreatedBy = detailDto.CreatedBy;
                return a;
            }).ToList();

            return Ok(approvalsDto);
        }

        private static void ApplyFiltersInMemory(string ambiente, string nomeAplicacao, ApprovalsPendingCountDto approvalsDto)
        {
            approvalsDto.Value = approvalsDto.Value.OrderBy(p => p.ReleaseDefinitionName).ToList();

            if (!string.IsNullOrEmpty(ambiente))
                approvalsDto.Value = approvalsDto.Value.Where(a =>
                                        a.ReleaseEnviromentName.ToUpper()
                                        .Contains(ambiente.ToUpper()))
                                        .ToList();
            if (!string.IsNullOrEmpty(nomeAplicacao))
                approvalsDto.Value = approvalsDto.Value.Where(a =>
                                        a.ReleaseDefinitionName.ToUpper()
                                        .Contains(nomeAplicacao.ToUpper()))
                                        .ToList();
        }

        /// <summary>
        /// Post approval in multiple releases
        /// </summary>
        /// <param name="user"></param>
        /// <param name="token"></param>
        /// <param name="approves"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("approvals/{user}/{token}")]
        public async Task<ActionResult> Approve(
            string user,
            string token,
            [FromBody] List<ApproveRequestDto> approves)
        {
            foreach (var approva in approves)
            {
                await _releaseClient.PostApprovalPendingAsync(user, token, approva.Id,
                    new ApproveRequestVSTSDto()
                    {
                        Comments = approva.Comments,
                        Status = approva.Status
                    });
            }

            return Ok();
        }
    }


}
