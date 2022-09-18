using System;

namespace DesignPatterns.flyweight.Exercise
{
    public class SpreadSheet
    {
        private const int MaxRows = 3;
        private const int MaxCols = 3;

        // In a real app, these values should not be hardcoded here.
        // They should be read from a configuration file.
        // private const string FontFamily = "Times New Roman";
        // private readonly int _fontSize = 12;
        // private readonly bool isBold = false;
        private readonly FontType _fontType = FontType.Body;

        private readonly Cell[,] _cells = new Cell[MaxRows, MaxCols];
        private TypographyFactory _typographyFactory;

        public SpreadSheet(TypographyFactory typographyFactory)
        {
            _typographyFactory = typographyFactory;
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            _cells[row, col].Content = content;
        }

        public void SetTypography(int row, int col, FontType type)
        {
            EnsureCellExists(row, col);

            _cells[row, col].Typography = _typographyFactory.GetTypography(type);
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
                var cell = new Cell(row, col, _typographyFactory.GetTypography(_fontType));
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