using System.Collections.Generic;

namespace Gherkin.Ast;

public class Feature : IHasLocation, IHasDescription, IHasTags, IHasChildren
{
    public IEnumerable<Tag> Tags { get; set; }
    public Location Location { get; set; }
    public string Language { get; set; }
    public string Keyword { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<IHasLocation> Children { get; set; }

    public Feature(Tag[] tags, Location location, string language, string keyword, string name, string description, IHasLocation[] children)
    {
        Tags = tags;
        Location = location;
        Language = language;
        Keyword = keyword;
        Name = name;
        Description = description;
        Children = children;
    }
}