namespace Factory.Method.Framework;

internal abstract class Controller
{
    public void Render(string viewName, Dictionary<string, object> context)
    {
        IViewEngine viewEngine = CreateViewEngine();
        string html = viewEngine.Render(viewName, context);

        Console.WriteLine(html);
    }

    protected virtual IViewEngine CreateViewEngine()
    {
        return new MatchaViewEngine();
    }
}
