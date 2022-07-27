using System.Collections.Generic;

namespace DesignPatterns.Facade.Exercise
{
    public class TweetService
    {
        public List<Tweet> GetRecentTweets()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey", "secret");
            var accessToken = oauth.GetAccessToken(requestToken);
            var twitterClient = new TweetClient();
            
            return twitterClient.GetRecentTweets(accessToken);
        }
    }
}