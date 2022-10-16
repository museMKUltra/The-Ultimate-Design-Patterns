using System;

namespace DesignPatterns.Proxy
{
    public interface IEbook
    {
        void Load();
        void Show();
        String GetFileName();
    }
}