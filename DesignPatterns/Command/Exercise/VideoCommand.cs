using System;

namespace DesignPatterns.Command.Exercise
{
    public class VideoCommand : IUndoableCommand
    {
        private float _prevContrast;
        private string _prevText;
        private readonly VideoEditor _videoEditor;
        private History _history;

        public VideoCommand(VideoEditor videoEditor, History history)
        {
            _videoEditor = videoEditor;
            _history = history;
        }

        public void Execute()
        {
            _prevContrast = _videoEditor.Contrast;
            _prevText = _videoEditor.Text;

            Console.WriteLine("execute video");

            _history.Push(this);
        }

        public void Unexecute()
        {
            _videoEditor.Contrast = _prevContrast;
            _videoEditor.Text = _prevText;
        }
    }
}