namespace Crawler.Models;

public class Crawl
{
    public int Id { get; set; }
    public string Url { get; set; }
    public uint Depth { get; set; }
    public List<string>? Links { get; set; }
    public DateTime Date { get; set; }

    public Crawl(int id, string url, uint depth, DateTime date, List<string> links)
    {
        Id = id;
        Url = url;
        Depth = depth;
        Date = date;
        Links = links;
    }

    public Crawl(string url, uint depth, DateTime date)
    {
        Url = url;
        Depth = depth;
        Date = date;
    }


}