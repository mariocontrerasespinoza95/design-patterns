namespace Factory.Method.Framework;

internal interface IViewEngine
{
    string Render(string viewName, Dictionary<string, object> context);
}
