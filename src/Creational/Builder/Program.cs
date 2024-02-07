using Builder;

/*
 * Builder is a creational design pattern that
 * lets you construct complex objects step by step.
 * The pattern allows you to produce
 * different types and representations of an object using the same construction code.
 */

var presentation = new Presentation();
presentation.AddSlide(new Slide("Slide 1"));
presentation.AddSlide(new Slide("Slide 2"));

var pdfBuilder = new PdfDocumentBuilder();
presentation.Export(pdfBuilder);
pdfBuilder.GetPdfDocument();

var movieBuilder = new MovieBuilder();
presentation.Export(movieBuilder);
movieBuilder.GetMovie();
