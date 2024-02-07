using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor;

public class PlainTextVisitor : IVisitor
{
    public void Apply(HeadingNode node) => Console.WriteLine("text-heading");

    public void Apply(AnchorNode node) => Console.WriteLine("anchor-heading");
}
