using System;

namespace DesignPatterns.flyweight.Exercise
{
    public class Cell
    {
        private readonly int _row;
        private readonly int _column;
        public string Content { get; set; }
        public Typography Typography { get; set; }

        public Cell(int row, int column, Typography typography) {
            _row = row;
            _column = column;
            Typography = typography;
        }

        public string GetFontFamily() {
            return Typography.FontFamily;
        }

        public int GetFontSize() {
            return Typography.FontSize;
        }

        public bool GetIsBold() {
            return Typography.IsBold;
        }

        public void Render() {
            Console.WriteLine($"({_row}, {_column}): {Content} {GetFontFamily()} {GetFontSize()} {GetIsBold()}");
        }
    }
}