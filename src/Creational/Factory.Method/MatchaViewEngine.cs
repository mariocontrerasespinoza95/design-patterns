using Factory.Method.Framework;

namespace Factory.Method;

internal class SharpViewEngine : IViewEngine
{
    public string Render(string viewName, Dictionary<string, object> context)
    {
        return "View rendered by Sharp";
    }
}
