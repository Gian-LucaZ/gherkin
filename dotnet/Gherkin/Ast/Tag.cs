namespace Gherkin.Ast;

public class Tag : IHasLocation
{
    public Location Location { get; set; }
    public string Name { get; set; }

    public Tag(Location location, string name)
    {
        Name = name;
        Location = location;
    }
}