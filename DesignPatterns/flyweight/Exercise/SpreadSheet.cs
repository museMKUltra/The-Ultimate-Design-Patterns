using System;

namespace DesignPatterns.flyweight.Exercise
{
    public class SpreadSheet
    {
        private const int MaxRows = 3;
        private const int MaxCols = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        private const string FontFamily = "Times New Roman";
        private readonly int _fontSize = 12;
        private readonly bool isBold = false;

        private readonly Cell[,] _cells = new Cell[MaxRows, MaxCols];

        public SpreadSheet()
        {
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            _cells[row, col].SetContent(content);
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            EnsureCellExists(row, col);

            _cells[row, col].SetFontFamily(fontFamily);
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MaxRows)
                throw new ArgumentException();

            if (col < 0 || col >= MaxCols)
                throw new ArgumentException();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MaxRows; row++)
            for (var col = 0; col < MaxCols; col++)
            {
                var cell = new Cell(row, col);
                cell.SetFontFamily(FontFamily);
                _cells[row, col] = cell;
            }
        }

        public void Render()
        {
            for (var row = 0; row < MaxRows; row++)
            for (var col = 0; col < MaxCols; col++)
                _cells[row, col].Render();
        }
    }
}