using AutoMapper;
using DevAzureManager.Models;
using DevAzureManager.Models.Azure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


            }, AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}