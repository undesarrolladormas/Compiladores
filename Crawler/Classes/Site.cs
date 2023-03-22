using System.Text.RegularExpressions;

namespace Crawler.Classes;

public class Site
{
    public string Url { get; set; }
    private string Text { get; set; }
    private int Depth { get; set; }

    private List<string> Links { get; set; }

    public Site(string url, int depth = 3)
    {
        this.Url = url;
        this.Depth = depth;
        var aux = WebDownload.Download(url);
        this.Text = aux != null ? aux : string.Empty ;
        Links = new();
    }

    public List<string> GetLinks()
    {
        Links.Clear();
        
        return Links;
    }

    private void CrawlText(string page)
    {
        List<string> auxLinks = new();
        Regex regex = new Regex(@"((https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w .-]*)*/?)|([\w-\.]+)@([\w-]+\.)+[\w-]{2,4}", RegexOptions.IgnoreCase);

        foreach (Match match in regex.Matches(page))
        {
            if (match.Value.Contains("http"))
            {
                auxLinks.Add(match.Value);
            }
        }

        Links.Union(auxLinks);
    }
}