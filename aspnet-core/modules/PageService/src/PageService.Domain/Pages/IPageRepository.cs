using System;
using Volo.Abp.Domain.Repositories;

namespace PageService.Pages
{
    public interface IPageRepository : IBasicRepository<Page, Guid>
    {
    }
}
