/*
 * Visitor is a behavioral design pattern
 * that lets you separate algorithms from the objects on which they operate.
 */

using DesignPatterns.Behavioral.Visitor;

var document = new HtmlDocument();
document.Add(new HeadingNode());
document.Add(new AnchorNode());

document.Execute(new HighlightVisitor());
document.Execute(new PlainTextVisitor());
