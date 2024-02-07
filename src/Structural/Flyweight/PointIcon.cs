namespace Flyweight;

public class PointIcon(PointType type, byte[]? icon)
{
    private readonly byte[]? _icon = icon;

    public PointType Type => type;
}
