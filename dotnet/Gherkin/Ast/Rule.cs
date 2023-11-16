using System.Collections.Generic;

namespace Gherkin.Ast;

public class Rule : IHasLocation, IHasDescription, IHasChildren, IHasTags
{
    public Location Location { get; set; }
    public string Keyword { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<Tag> Tags { get; set; }
    public IEnumerable<IHasLocation> Children { get; set; }

    public Rule(Tag[] tags, Location location, string keyword, string name, string description, IHasLocation[] children)
    {
        Location = location;
        Keyword = keyword;
        Name = name;
        Description = description;
        Children = children;
        Tags = tags;
    }
}