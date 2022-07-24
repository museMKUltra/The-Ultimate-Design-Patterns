namespace DesignPatterns.Decorator.Exercise
{
    public class Artefact : IArtefact
    {
        private string _name;

        public Artefact(string name)
        {
            _name = name;
        }

        public string Render()
        {
            return _name;
        }
    }
}