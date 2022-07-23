using System.Collections.Generic;

namespace DesignPatterns.Adapter.Exercise
{
    public class EmailClient
    {
        private List<IEmailProvider> _emailProviders = new();

        public void AddProvider(IEmailProvider emailProvider)
        {
            _emailProviders.Add(emailProvider);
        }
        public void DownloadEmail()
        {
            foreach (var emailProvider in _emailProviders)
            {
                emailProvider.DownloadEmail();
            }
        }
    }
}