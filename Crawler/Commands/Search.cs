using Spectre.Console;
using Cocona;
using Crawler.Classes;

namespace Crawler.Commands;

public class Search
{
    [Command(Description = "Get the URL and crawl it")]
    public static void Crawl([Argument(Description = "Target to be crawled")]string url, [Option('d', Description = "Depth of the crawl")]uint depth = 3)
    {
        AnsiConsole.Markup($"[yellow]Crawling[/] [blue]{url}[/] \n\n");
        try {
            string web = WebDownload.Download(url);
            Site site = new Site(web);
            site.GetLinks().ForEach(link => AnsiConsole.Markup($"[green]{link}[/] \n"));
        }
        catch(Exception ex)
        {
            AnsiConsole.Markup($"[red]Error: {ex.Message} [/]");
        }
        
    }
}
