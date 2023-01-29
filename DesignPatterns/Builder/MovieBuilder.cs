namespace DesignPatterns.Builder
{
    public class MovieBuilder : IPresentationBuilder
    {
        private Movie _movie = new();

        public void AddSlide(Slide slide)
        {
            _movie.AddFrame(slide.Text, 3);
        }

        public Movie GetMovie()
        {
            return _movie;
        }
    }
}