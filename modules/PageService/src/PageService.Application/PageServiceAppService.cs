using PageService.Localization;
using Volo.Abp.Application.Services;

namespace PageService;

public abstract class PageServiceAppService : ApplicationService
{
    protected PageServiceAppService()
    {
        LocalizationResource = typeof(PageServiceResource);
        ObjectMapperContext = typeof(PageServiceApplicationModule);
    }
}
