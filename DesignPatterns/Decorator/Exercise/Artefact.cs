namespace DesignPatterns.Decorator.Exercise
{
    public class Artefact
    {
        private bool _isMain;
        private bool _hasError;
        private string _name;

        public Artefact(string name)
        {
            _name = name;
        }
        public string Render()
        {
            var errorIcon = _hasError ? " [Error]" : "";
            var mainIcon = _isMain ? " [Main]" : "";

            return $"{_name}{errorIcon}{mainIcon}";
        }

        public void SetMain(bool isMain)
        {
            _isMain = isMain;
        }

        public void SetHasError(bool hasError)
        {
            _hasError = hasError;
        }
    }
}