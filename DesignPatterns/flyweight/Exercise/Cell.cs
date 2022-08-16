using System;

namespace DesignPatterns.flyweight.Exercise
{
    public class Cell
    {
        private readonly int _row;
        private readonly int _column;
        private string _content;
        private string _fontFamily;
        private int _fontSize;
        public bool IsBold { get; }

        public Cell(int row, int column) {
            _row = row;
            _column = column;
        }

        public string GetContent() {
            return _content;
        }

        public void SetContent(string content) {
            _content = content;
        }

        public string GetFontFamily() {
            return _fontFamily;
        }

        public void SetFontFamily(string fontFamily) {
            _fontFamily = fontFamily;
        }

        public int GetFontSize() {
            return _fontSize;
        }

        public void SetFontSize(int fontSize) {
            _fontSize = fontSize;
        }

        public void Render() {
            Console.WriteLine($"({_row}, {_column}): {_content} {_fontFamily}");
        }
    }
}