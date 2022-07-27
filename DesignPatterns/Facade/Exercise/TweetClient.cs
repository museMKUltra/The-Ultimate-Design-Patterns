using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade.Exercise
{
    public class TweetClient
    {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("get recent tweets");
            return new List<Tweet>();
        }
    }
}