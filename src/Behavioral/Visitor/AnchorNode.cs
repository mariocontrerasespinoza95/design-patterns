namespace DesignPatterns.Behavioral.Visitor;

public class AnchorNode : IHtmlNode
{
    public void Execute(IVisitor visitor) => visitor.Apply(this);
}
