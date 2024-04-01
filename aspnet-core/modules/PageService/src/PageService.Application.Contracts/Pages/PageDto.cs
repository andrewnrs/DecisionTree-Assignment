using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace PageService.Samples;

[Serializable]
public class PageDto : EntityDto<Guid> //: IValidatableObject
{
    public PageDto()
    {
    }

    private PageDto(string title, string slug, string content, string? style, bool isHomePage)
    {
        Title = title;
        Slug = slug;
        Content = content;
        Style = style;
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

    [StringLength(1000)]
    public string? Style { get; set; }

    //[Required]
    public bool IsHomePage { get; set; } = false;



    public static PageDto TestingPage()
        => new("Test Page", "test", "<h1>TESTING..!</h1>", "", false);

    public static PageDto HomePage()
        => new("Home Page", "home-page", "<h6>Welcome!</h6>", "", true);

    public static PageDto AboutUs()
        => new("About Us", "about-us", "<h1>We are awesome!</h1>", "", false);


    //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    //{        
    //}
}
