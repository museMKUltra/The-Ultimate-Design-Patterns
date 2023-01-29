using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Presentation
    {
        private List<Slide> _slides = new ();

        public void AddSlide(Slide slide)
        {
            _slides.Add(slide);
        }

        public void Export(PresentationFormat format)
        {
            if (format == PresentationFormat.Pdf)
            {
                var pdf = new PdfDocument();
                pdf.AddPage("Copyright");
                foreach (var slide in _slides)
                {
                    pdf.AddPage(slide.Text);
                }
            }
            else if (format == PresentationFormat.Movie)
            {
                var movie = new Movie();
                movie.AddFrame("Copyright", 3);
                foreach (var slide in _slides)
                {
                    movie.AddFrame(slide.Text, 3);
                }
            }
        }
    }
}