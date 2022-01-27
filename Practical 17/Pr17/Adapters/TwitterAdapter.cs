using System;
using Pr17.Twitter;

namespace Pr17.Adapters
{
    class TwitterAdapter : IAdapter
    {
        private readonly ITwitter _twitter;
        public TwitterAdapter(ITwitter twitter)
        {
            _twitter = twitter;
        }
        public string Name
        {
            get { return _twitter.twitterName; }
        }
        public int Age
        {
            get { return _twitter.twitterAge; }
        }
        public int NumberOfFriends
        {
            get { return _twitter.twitterNumberOfFriends; }
        }
    }
}
