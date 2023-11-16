namespace Gherkin.Ast;

public class DocString : StepArgument, IHasLocation
{
    public Location Location { get; set; }
    public string ContentType { get; set; }
    public string Content { get; set; }
    public string Delimiter { get; set; }

    public DocString(Location location, string contentType, string content, string delimiter = null)
    {
        Location = location;
        ContentType = contentType;
        Content = content;
        Delimiter = delimiter;
    }
}