using Spectre.Console;
using Crawler.Classes;
using Cocona;

namespace Crawler.Commands;

public class ListDB
{
    [Command(Description = "List all the URLs crawled in the database")]
    public void List()
    {
        var crawls = DBConnection.ListCrawls();
        var table = new Table();
        table.AddColumn("URL");
        table.AddColumn("Depth");
        table.AddColumn("Date");
        foreach (var crawl in crawls)
        {
            table.AddRow(crawl.Url, crawl.Depth.ToString(), crawl.Date.ToShortDateString());
        }
        AnsiConsole.Write(table);
    }

    [Command(Description = "Consult a specific URL in the database")]
    public void Consult(string url)
    {

    }
}