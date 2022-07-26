using DesignPatterns.Facade;

namespace DesignPatterns
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var notificationServer = new NotificationServer();
            var connection = notificationServer.Connect("ipAddress");
            var authToken = notificationServer.Authenticate("appId", "key");
            notificationServer.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}