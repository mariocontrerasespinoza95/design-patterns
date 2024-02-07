using Factory.Method.Framework;

namespace Factory.Method;

internal class MatchaViewEngine : IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context) => "View rendered by Matcha";
}
