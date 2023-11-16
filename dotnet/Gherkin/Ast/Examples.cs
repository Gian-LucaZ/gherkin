using System.Collections.Generic;
using System.Linq;

namespace Gherkin.Ast;

public class Examples : IHasLocation, IHasDescription, IHasRows, IHasTags
{
    public IEnumerable<Tag> Tags { get; set; }
    public Location Location { get; set; }
    public string Keyword { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public TableRow TableHeader { get; set; }
    public IEnumerable<TableRow> TableBody { get; set; }

    public Examples(Tag[] tags, Location location, string keyword, string name, string description, TableRow header, TableRow[] body)
    {
        Tags = tags;
        Location = location;
        Keyword = keyword;
        Name = name;
        Description = description;
        TableHeader = header;
        TableBody = body;
    }

    IEnumerable<TableRow> IHasRows.Rows
    {
        get { return new[] {TableHeader}.Concat(TableBody); }
        set
        {
            TableHeader = value.First();
            TableBody = value.Skip(1);
        }
    }
}