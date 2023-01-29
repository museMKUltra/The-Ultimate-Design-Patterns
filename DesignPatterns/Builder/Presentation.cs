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

        public void Export(IPresentationBuilder builder)
        {
            // We have a single place where we have implemented the exporting logic
            builder.AddSlide(new Slide("Copyright"));
            foreach (var slide in _slides)
            {
                builder.AddSlide(slide);
            }
        }
    }
}