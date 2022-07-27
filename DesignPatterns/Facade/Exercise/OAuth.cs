using System;

namespace DesignPatterns.Facade.Exercise
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("get a request token");
            return "request token";
        }
        
        public string GetAccessToken(string requestToken)
        {
            Console.WriteLine("get a access token");
            return "access token";
        }
    }
}