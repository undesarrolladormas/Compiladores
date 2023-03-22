namespace Crawler.Classes;

public class Automata
{
    public enum State{

    }

    public State state { get; set; }

    private string text { get; set; }

    public Automata(string text)
    {
        this.text = text;
    }

    

}