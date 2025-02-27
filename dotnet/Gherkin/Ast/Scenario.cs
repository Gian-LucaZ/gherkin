using System.Collections.Generic;

namespace Gherkin.Ast;

public class Scenario : StepsContainer, IHasTags
{
    public IEnumerable<Tag> Tags { get; set; }
    public IEnumerable<Examples> Examples { get; set; }

    public Scenario(Tag[] tags, Location location, string keyword, string name, string description, Step[] steps, Examples[] examples) 
        : base(location, keyword, name, description, steps)
    {
        Tags = tags;
        Examples = examples;
    }
}