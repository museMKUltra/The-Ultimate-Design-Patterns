using System;

namespace DesignPatterns
{
    public class MailService
    {
        public void SendEmail()
        {
            Connect(1);
            Authenticate();
            // Send email
            Disconnect();
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnect");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticate");
        }

        private void Connect(int timeout)
        {
            Console.WriteLine($"Connect {timeout}");
        }
    }
}