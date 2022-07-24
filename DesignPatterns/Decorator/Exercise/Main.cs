namespace DesignPatterns.Decorator.Exercise
{
    public class Main : IArtefact
    {
        private IArtefact _artefact;

        public Main(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return _artefact.Render() + " [Main]";
        }
    }
}