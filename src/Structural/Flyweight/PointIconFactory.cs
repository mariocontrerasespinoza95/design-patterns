namespace Flyweight;

public class PointIconFactory
{
    private readonly Dictionary<PointType, PointIcon> _icons = [];

    public PointIcon GetPointIcon(PointType type)
    {
        if (_icons.TryGetValue(type, out PointIcon? value))
        {
            return value;
        }

        var icon = new PointIcon(type, null);
        value = icon;
        _icons.Add(type, value);

        return value;
    }
}
