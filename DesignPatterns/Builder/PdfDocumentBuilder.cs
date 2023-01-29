namespace DesignPatterns.Builder
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument _document = new();

        public void AddSlide(Slide slide)
        {
            _document.AddPage(slide.Text);
        }

        public PdfDocument GetPdfDocument()
        {
            return _document;
        }
    }
}