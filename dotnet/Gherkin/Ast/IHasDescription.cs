namespace Gherkin.Ast;

public interface IHasDescription
{
    string Keyword { get; set; }
    string Name { get; set; }
    string Description { get; set; }
}