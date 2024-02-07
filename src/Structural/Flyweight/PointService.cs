namespace Flyweight;

public class PointService(PointIconFactory iconFactory)
{
    public List<Point> GetPoints()
    {
        List<Point> points = [];
        var point = new Point(x: 1, y: 2, iconFactory.GetPointIcon(PointType.CAFE));
        points.Add(point);

        return points;
    }
}
