using System;
using System.Threading;
using TweetSharp.Twitter.Model;

namespace Twitterr.Specs.Helpers
{
    public static class AsyncHelpers
    {
        public static IAsyncResult WaitToComplete(this IAsyncResult result)
        {
            WaitHandle.WaitAll(new[] { result.AsyncWaitHandle }, new TimeSpan(0, 0, 5));
            return result;
        }
    }
}