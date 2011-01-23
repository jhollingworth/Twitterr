using System;
using Machine.Specifications;
using Twitterr.Specs.Helpers;
using Twitterr.Tasks;

namespace Twitterr.Specs.Tasks.Twitter
{
    public class When_I_update_my_status
    {
        static TwitterTasks Twitter;
        static IAsyncResult Result;
        
        Establish context = () => Twitter = new TwitterTasks();
        Because I_updated_my_status = () => Result = Twitter.Tweet("Hello world").WaitToComplete();
        It will_update_my_status = () => Result.IsCompleted.ShouldEqual(true);
    }
}