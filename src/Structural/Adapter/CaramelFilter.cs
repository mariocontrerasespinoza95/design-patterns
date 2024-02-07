using Adapter.FrameworkFilters;

namespace Adapter;

public class CaramelFilter : IFilter
{
    private readonly Caramel _caramel = new();

    public void Apply(Image image)
    {
        _caramel.Init();
        _caramel.Render(image);
    }
}
