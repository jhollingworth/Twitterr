using System;
using TweetSharp.Twitter.Fluent;
using TweetSharp.Twitter.Model;

namespace Twitterr.Tasks
{
    public class TwitterTasks
    {
        public IAsyncResult Tweet(string status)
        {
            return Twitter
                .Statuses()
                .Update(status)
                .BeginRequest();
        }

        public IAsyncResult Timeline(Action<TwitterResult> callback)
        {
            return Twitter
                .Statuses()
                .OnHomeTimeline()
                .CallbackTo((sender, args, userState) => callback(args))
                .BeginRequest();
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
