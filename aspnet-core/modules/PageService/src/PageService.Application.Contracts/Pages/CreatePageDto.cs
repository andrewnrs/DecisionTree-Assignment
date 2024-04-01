using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace PageService.Samples;

[Serializable]
public class CreatePageDto(string title, string slug, string content, string? style, bool isHomePage) : CreationAuditedEntityDto<Guid>
{
    [Required]
    [StringLength(60)]
    [RegularExpression("^[a-zA-Z0-9- ]*$")]
    public string Title { get; set; } = title;

    [Required]
    [StringLength(60)]
    [RegularExpression("^[a-zA-Z0-9-]*$")]
    public string Slug { get; set; } = slug;

    [Required]
    [StringLength(1000)]
    public string Content { get; set; } = content;

    [StringLength(1000)]
    public string? Style { get; set; } = style;

    public bool IsHomePage { get; set; } = isHomePage;
}
