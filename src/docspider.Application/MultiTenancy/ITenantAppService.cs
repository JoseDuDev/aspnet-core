﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using docspider.MultiTenancy.Dto;

namespace docspider.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
