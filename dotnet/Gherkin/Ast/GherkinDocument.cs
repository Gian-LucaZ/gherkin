using System.Collections.Generic;

namespace Gherkin.Ast;

public class GherkinDocument
{
    public Feature Feature { get; set; }
    public IEnumerable<Comment> Comments { get; set; }

    public GherkinDocument(Feature feature, Comment[] comments)
    {
        Feature = feature;
        Comments = comments;
    }
}