namespace Builder;

internal class Presentation
{
    private List<Slide> slides = [];

    public void AddSlide(Slide slide) { slides.Add(slide); }
    public void Export(IPresentationBuilder builder)
    {
        builder.AddSlide(new Slide("Copyright"));
        foreach (Slide slide in slides)
        {
            builder.AddSlide(slide);
        }
    }
}
