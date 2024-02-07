using Factory.Method.Framework;

namespace Factory.Method;

internal class SharpController : Controller
{
    protected override IViewEngine CreateViewEngine() => new SharpViewEngine();
}
