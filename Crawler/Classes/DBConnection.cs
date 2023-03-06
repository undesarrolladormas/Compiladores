using Crawler.Models;
using LiteDB;

namespace Crawler.Classes;

public static class DBConnection
{
    static readonly string DATABASE_URI = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Crawler\\crawler.db";

    public static bool AddCrawl(Crawl crawl)
    {
        using (var db = new LiteDatabase(DATABASE_URI))
        {
            var col = db.GetCollection<Crawl>("crawls");
            col.Insert(crawl);
            return true;
        }
    }

    public static List<Crawl> ListCrawls()
    {
        using (var db = new LiteDatabase(DATABASE_URI))
        {
            var col = db.GetCollection<Crawl>("crawls");
            return col.Query().Select(x => new Crawl(x.Url, x.Depth, x.Date)).ToList();
        }
    }
}