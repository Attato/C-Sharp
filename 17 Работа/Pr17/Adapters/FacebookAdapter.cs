using System;
using Pr17.Facebook;

namespace Pr17.Adapters
{
    class FacebookAdapter : IAdapter
    {
        private readonly IFacebook _facebook;
        public FacebookAdapter(IFacebook facebook)
        {
            _facebook = facebook;
        }
        public string Name
        {
            get { return _facebook.facebookName; }
        }
        public int Age
        {
            get { return _facebook.facebookAge; }
        }
        public int NumberOfFriends
        {
            get { return _facebook.facebookNumberOfFriends; }
        }
    }
}
