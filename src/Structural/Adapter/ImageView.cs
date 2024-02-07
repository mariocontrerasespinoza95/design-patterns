namespace Adapter;

public class ImageView(Image image)
{
    public void Apply(IFilter filter)
    {
        filter.Apply(image);
    }
}
