namespace Gherkin.Ast;

public class Step : IHasLocation
{
    public Location Location { get; set; }
    public string Keyword { get; set; }
    public StepKeywordType KeywordType { get; }

    public string Text { get; set; }
    public StepArgument Argument { get; set; }

    public Step(Location location, string keyword, StepKeywordType keywordType, string text, StepArgument argument)
    {
        Location = location;
        Keyword = keyword;
        KeywordType = keywordType;
        Text = text;
        Argument = argument;
    }
}