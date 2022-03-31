using System;

namespace DesignPatterns.Mediator.Observer
{
    public class ArticlesDialogBox
    {
        private ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _articlesListBox.AddEventHandler(ArticleSelected);
            _titleTextBox.AddEventHandler(TitleChanged);
        }

        private void TitleChanged()
        {
            var content = _titleTextBox.Content;
            var isNullOrEmpty = string.IsNullOrEmpty(content);

            _saveButton.IsEnabled = !isNullOrEmpty;
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.IsEnabled = true;
        }

        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Article 1";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");

            _titleTextBox.Content = "";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");

            _titleTextBox.Content = "Article 2";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");
        }
    }
}