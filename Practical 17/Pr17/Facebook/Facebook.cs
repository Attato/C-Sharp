using System;

namespace Pr17.Facebook
{
    public class Facebook : IFacebook
    {
        private readonly string _facebookName;
        private readonly int _facebookAge;
        private readonly int _facebookNumberOfFriends;

        public Facebook(string facebookName, int facebookAge, int facebookNumberOfFriends)
        {

            _facebookName = facebookName;
            _facebookAge = facebookAge;
            _facebookNumberOfFriends = facebookNumberOfFriends;
        }

        public string facebookName
        {
            get { return _facebookName; }
        }
        public int facebookAge
        {
            get { return _facebookAge; }
        }
        public int facebookNumberOfFriends
        {
            get { return _facebookNumberOfFriends; }
        }
    }
}
