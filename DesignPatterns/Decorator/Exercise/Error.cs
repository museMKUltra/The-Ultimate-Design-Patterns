namespace DesignPatterns.Decorator.Exercise
{
    public class Error : IArtefact
    {
        private IArtefact _artefact;

        public Error(IArtefact artefact)
        {
            _artefact = artefact;
        }

        public string Render()
        {
            return _artefact.Render() + " [Error]";
        }
    }
}