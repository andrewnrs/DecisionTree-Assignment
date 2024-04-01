using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace PageService.Samples;

[Serializable]
public class PageResponseDto : AuditedEntityDto<Guid>
{
    public PageResponseDto() { }

    public PageResponseDto(string title, string slug, string content, bool isHomePage)
    {
        Title = title;
        Slug = slug;
        Content = content;
        IsHomePage = isHomePage;
    }

    public string Title { get; set; }

    public string Slug { get; set; }

    public string Content { get; set; }

    public bool IsHomePage { get; set; }
}
