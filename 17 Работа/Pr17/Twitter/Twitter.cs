using System;

namespace Pr17.Twitter
{
    public class Twitter : ITwitter
    {
        private readonly string _twitterName;
        private readonly int _twitterAge;
        private readonly int _twitterNumberOfFriends;

        public Twitter(string twitterName, int twitterAge, int twitterNumberOfFriends)
        {

            _twitterName = twitterName;
            _twitterAge = twitterAge;
            _twitterNumberOfFriends = twitterNumberOfFriends;
        }

        public string twitterName
        {
            get { return _twitterName; }
        }
        public int twitterAge
        {
            get { return _twitterAge; }
        }
        public int twitterNumberOfFriends
        {
            get { return _twitterNumberOfFriends; }
        }
    }
}
