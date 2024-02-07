namespace Factory.Method;

internal class ProductsController : SharpController
{
    public void ListProducts()
    {
        var context = new Dictionary<string, object>();

        Render(viewName: "products.html", context);
    }
}
