namespace Gherkin.Ast;

public class Comment : IHasLocation
{
    public Location Location { get; set; }
    public string Text { get; set; }

    public Comment(Location location, string text)
    {
        Text = text;
        Location = location;
    }
}