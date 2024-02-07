namespace Builder;

internal class PdfDocumentBuilder : IPresentationBuilder
{
    private readonly PdfDocument _document = new();

    public void AddSlide(Slide slide)
    {
        _document.AddPage(slide.Text);
    }

    internal PdfDocument GetPdfDocument()
    {
        return _document;
    }
}
