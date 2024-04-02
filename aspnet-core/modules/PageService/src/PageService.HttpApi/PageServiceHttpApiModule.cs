﻿using Localization.Resources.AbpUi;
using PageService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace PageService;

[DependsOn(
    typeof(PageServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PageServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PageServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PageServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
