namespace DesignPatterns.Behavioral.Visitor;

public class HtmlDocument
{
    private readonly List<IHtmlNode> _nodes = [];

    public void Add(IHtmlNode node) => _nodes.Add(node);

    public void Execute(IVisitor visitor) => _nodes.ForEach(node => node.Execute(visitor));
}
