using System;

namespace Pr17.Vk
{
    public class Vk : IVk
    {
        private readonly string _vkName;
        private readonly int _vkAge;
        private readonly int _vkNumberOfFriends;

        public Vk(string vkName, int vkAge, int vkNumberOfFriends)
        {

            _vkName = vkName;
            _vkAge = vkAge;
            _vkNumberOfFriends = vkNumberOfFriends;
        }

        public string vkName
        {
            get { return _vkName; }
        }
        public int vkAge
        {
            get { return _vkAge; }
        }
        public int vkNumberOfFriends
        {
            get { return _vkNumberOfFriends; }
        }
    }
}
