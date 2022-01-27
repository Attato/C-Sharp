using System;

namespace Pr17.Twitter
{
    public interface ITwitter
    {
        string twitterName { get; }
        int twitterAge { get; }
        int twitterNumberOfFriends { get; }
    }
}
