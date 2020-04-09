using AutoMapper;
using DevAzureManager.Models;
using DevAzureManager.Models.Azure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DevAzureManager.Application
{ 

    public static class ConfigureAutomapper
    {

        public static void ConfigureAutomapperTypes(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<ApprovalsPendingVSTSCountDto, ApprovalsPendingCountDto>();

                cfg.CreateMap<ApprovalsPendingVSTSDto, ApprovalsPendingDto>()
                    .ForMember(o => o.ReleaseId, s => s.MapFrom(n => n.Release.Id))
                    .ForMember(o => o.ReleaseName, s => s.MapFrom(n => n.Release.Name))
                    .ForMember(o => o.ReleaseDefinitionId, s => s.MapFrom(n => n.ReleaseDefinition.Id))
                    .ForMember(o => o.ReleaseDefinitionName, s => s.MapFrom(n => n.ReleaseDefinition.Name))
                    .ForMember(o => o.ReleaseEnviromentName, s => s.MapFrom(n => n.ReleaseEnvironment.Name));

                cfg.CreateMap<ReleaseDetailVSTSDto, ReleaseDetailDto>()
                    .ForMember(o => o.CreatedBy, s => s.MapFrom(n => n.createdBy.displayName))
                    .ForMember(o => o.Branch, s => s.MapFrom(n => n.artifacts.First().definitionReference.branches.name));

                cfg.CreateMap<ReleaseResponseVSTSDto, ReleaseResponseDto>();

                cfg.CreateMap<ReleaseResponseListVSTSDto, ReleaseResponseListDto>()
                    .ForMember(o => o.IdRelease, s => s.MapFrom(n => n.release.Id))
                    .ForMember(o => o.NameRelease, s => s.MapFrom(n => n.release.Name))
                    .ForMember(o => o.NameReleaseDefinition, s => s.MapFrom(n => n.releaseDefinition.Name))
                    .ForMember(o => o.Enviroment, s => s.MapFrom(n => n.releaseEnvironment.name));

            }, AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}