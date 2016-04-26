﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Wu.MyProject.MultiTenancy.Dto;

namespace Wu.MyProject.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        System.Threading.Tasks.Task CreateTenant(CreateTenantInput input);
    }
}
