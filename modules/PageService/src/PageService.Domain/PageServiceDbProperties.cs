namespace PageService;

public static class PageServiceDbProperties
{
    public static string DbTablePrefix { get; set; } = "PageService";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "PageService";
}
