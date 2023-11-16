using System.Collections.Generic;

namespace Gherkin.Ast;

public abstract class StepsContainer : IHasLocation, IHasDescription, IHasSteps
{
    public Location Location { get; set; }
    public string Keyword { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<Step> Steps { get; set; }

    protected StepsContainer(Location location, string keyword, string name, string description, Step[] steps)
    {
        Location = location;
        Keyword = keyword;
        Name = name;
        Description = description;
        Steps = steps;
    }
}