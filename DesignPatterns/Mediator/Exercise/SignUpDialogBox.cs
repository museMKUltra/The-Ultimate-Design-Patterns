using System;

namespace DesignPatterns.Mediator.Exercise
{
    public class SignUpDialogBox
    {
        private Button _signUpButton;
        private CheckBox _termsCheckBox;
        private TextBox _usernameTextBox;
        private TextBox _passwordTextBox;

        public SignUpDialogBox()
        {
            _signUpButton = new Button();
            _termsCheckBox = new CheckBox();
            _usernameTextBox = new TextBox();
            _passwordTextBox = new TextBox();

            _termsCheckBox.AddEventHandler(CheckSignUpButton);
            _usernameTextBox.AddEventHandler(CheckSignUpButton);
            _passwordTextBox.AddEventHandler(CheckSignUpButton);
        }

        private void CheckSignUpButton()
        {
            var isUsernameFilledOut = !string.IsNullOrEmpty(_usernameTextBox.Content);
            var isPasswordFilledOut = !string.IsNullOrEmpty(_passwordTextBox.Content);
            var isTermsChecked = _termsCheckBox.IsChecked;

            _signUpButton.IsEnabled = isUsernameFilledOut && isPasswordFilledOut && isTermsChecked;
        }

        public void SimulateUserInteraction()
        {
            Console.WriteLine($"sign up button: {_signUpButton.IsEnabled}");

            _usernameTextBox.Content = "username";
            Console.WriteLine($"username: {_usernameTextBox.Content}");
            Console.WriteLine($"sign up button: {_signUpButton.IsEnabled}");

            _passwordTextBox.Content = "password";
            Console.WriteLine($"password: {_passwordTextBox.Content}");
            Console.WriteLine($"sign up button: {_signUpButton.IsEnabled}");

            _termsCheckBox.IsChecked = true;
            Console.WriteLine($"terms checked: {_termsCheckBox.IsChecked}");
            Console.WriteLine($"sign up button: {_signUpButton.IsEnabled}");
        }
    }
}