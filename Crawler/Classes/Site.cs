namespace Crawler.Classes;

public class Site{

    enum State {
        Start,
        Http1,
        Http2,
        Http3,
        Http4,
        Https,
        Semicolon,
        Slash1,
        Slash2,
        Domain,
        Dot,
        TLD,
        Path,
        Query,
        Fragment,
        Match
    }

    public string Text { get; set; }

    public Site(string Text)
    {
        this.Text = Text;
    }

    public List<string> GetLinks()
    {
        List<string> Links = new();
        int pos = 0;
        State state = State.Start;
        string buffer = "";

        while (pos < Text.Length) 
        {
            
        }
        return Links;
    }
}