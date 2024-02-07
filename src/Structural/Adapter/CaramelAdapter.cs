using Adapter.FrameworkFilters;

namespace Adapter;

internal class CaramelAdapter : Caramel, IFilter
{
    public void Apply(Image image)
    {
        Init();
        Render(image);
    }
}
