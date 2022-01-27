using System;
using Pr17.Vk;

namespace Pr17.Adapters
{
    class VkAdapter : IAdapter
    {
        private readonly IVk _vk;
        public VkAdapter(IVk vk)
        {
            _vk = vk;
        }
        public string Name
        {
            get { return _vk.vkName; }
        }
        public int Age
        {
            get { return _vk.vkAge; }
        }
        public int NumberOfFriends
        {
            get { return _vk.vkNumberOfFriends; }
        }
    }
}
