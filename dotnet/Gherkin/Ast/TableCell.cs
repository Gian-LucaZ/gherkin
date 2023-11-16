namespace Gherkin.Ast;

public class TableCell : IHasLocation
{
    public Location Location { get; set; }
    public string Value { get; set; }

    public TableCell(Location location, string value)
    {
        Location = location;
        Value = value;
    }
}