using AutoMapper;
using PageService.Pages;
using PageService.Samples;
using Volo.Abp.AutoMapper;

namespace PageService;

public class PageServiceApplicationAutoMapperProfile : Profile
{
    public PageServiceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<CreatePageDto, Page>()
            .IgnoreAuditedObjectProperties();

        CreateMap<Page, PageResponseDto>();
    }
}
