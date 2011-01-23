using System;
using Machine.Specifications;
using TweetSharp.Twitter.Extensions;
using TweetSharp.Twitter.Model;
using Twitterr.Specs.Helpers;
using Twitterr.Tasks;

namespace Twitterr.Specs.Tasks.Twitter
{
    public class When_I_get_my_timeline
    {
        static TwitterTasks Twitter;
        static TwitterResult Result;

        Establish context = () => Twitter = new TwitterTasks();
        Because I_updated_my_status = () => Twitter.Timeline(r => Result = r).WaitToComplete();
        It will_update_my_status = () => Result.AsStatuses().ShouldNotBeNull();
    }
}