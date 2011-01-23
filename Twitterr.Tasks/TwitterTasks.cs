using System;
using TweetSharp.Twitter.Fluent;

namespace Twitterr.Tasks
{
    public class TwitterTasks
    {
        public IAsyncResult Tweet(string status)
        {
            return Twitter.Statuses().Update(status).BeginRequest();
        }

        private static IFluentTwitter Twitter
        {
            get
            {
                return FluentTwitter.CreateRequest()
                    .AuthenticateWith(Settings.ConsumerKey, Settings.ConsumerSecret, Settings.Token, Settings.TokenSecret);
            }
        }
    }
}
