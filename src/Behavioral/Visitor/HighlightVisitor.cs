using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor;

internal class HighlightVisitor : IVisitor
{
    public void Apply(HeadingNode node) => Console.WriteLine("highlight-heading");

    public void Apply(AnchorNode node) => Console.WriteLine("highlight-anchor");
}
