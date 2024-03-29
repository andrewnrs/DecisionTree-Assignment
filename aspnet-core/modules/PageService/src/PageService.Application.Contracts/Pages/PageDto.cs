namespace PageService.Samples;

public class PageDto
{
    public PageDto()
    {
    }

    private PageDto(string title, string slug, string content, string? script, string? style, bool isHomePage)
    {
        Title = title;
        Slug = slug;
        Content = content;
        Script = script;
        Style = style;
        IsHomePage = isHomePage;
    }

    public string Title { get; set; }
    public string Slug { get; set; }
    public string Content { get; set; }
    public string? Script { get; set; }
    public string? Style { get; set; }
    public bool IsHomePage { get; set; } = false;



    public static PageDto TestingPage()
        => new("Test Page", "test", "<h1>TESTING..!</h1>", null, "", false);

    public static PageDto HomePage()
        => new("Home Page", "home-page", "<h6>Welcome Furico!</h6>", null, "", true);

    public static PageDto AboutUs()
        => new("About Us", "about-us", "<h1>We are awesome!</h1>", null, "", false);
}
