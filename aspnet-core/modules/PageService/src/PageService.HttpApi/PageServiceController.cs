using PageService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PageService;

public abstract class PageServiceController : AbpControllerBase
{
    protected PageServiceController()
    {
        LocalizationResource = typeof(PageServiceResource);
    }
}
