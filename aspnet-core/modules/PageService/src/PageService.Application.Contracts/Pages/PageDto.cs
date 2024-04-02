using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace PageService.Samples;

[Serializable]
public class PageDto : EntityDto<Guid>
{
    public PageDto()
    {
    }

    private PageDto(string title, string slug, string content, bool isHomePage)
    {
        Title = title;
        Slug = slug;
        Content = content;
        IsHomePage = isHomePage;
    }


    [Required]
    [StringLength(60)]
    [RegularExpression("^[a-zA-Z0-9- ]*$")]
    public string Title { get; set; }

    [Required]
    [StringLength(60)]
    [RegularExpression("^[a-zA-Z0-9-]*$")]
    public string Slug { get; set; }

    [Required]
    [StringLength(1000)]
    public string Content { get; set; }

    public bool IsHomePage { get; set; } = false;


    public static PageDto HomePage()
        => new("Home Page", "home-page", "<h6>Welcome!</h6>", true);

    public static PageDto AboutUs()
        => new("About Us", "about-us", "<h1>We are awesome!</h1>", false);
}
