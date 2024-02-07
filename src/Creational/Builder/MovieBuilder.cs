namespace Builder;

internal class MovieBuilder : IPresentationBuilder
{
    private readonly Movie _movie = new();

    public void AddSlide(Slide slide)
    {
        _movie.AddFrame(slide.Text, 3);
    }

    internal Movie GetMovie()
    {
        return _movie;
    }
}
