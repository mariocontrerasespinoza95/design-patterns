namespace DesignPatterns.Behavioral.Visitor;

public interface IVisitor
{
    void Apply(HeadingNode node);
    void Apply(AnchorNode node);
}
