namespace DesignPatterns.Adapter.Exercise
{
    public class GmailProvider : IEmailProvider
    {
        private GmailClient _gmailClient;

        public GmailProvider(GmailClient gmailClient)
        {
            _gmailClient = gmailClient;
        }

        public void DownloadEmail()
        {
            _gmailClient.Connect();
            _gmailClient.GetEmails();
            _gmailClient.Disconnect();
        }
    }
}