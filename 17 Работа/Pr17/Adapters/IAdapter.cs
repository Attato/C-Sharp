using System;

namespace Pr17.Adapters
{
    public interface IAdapter
    {
        string Name { get; }
        int Age { get; }
        int NumberOfFriends { get; }
    }
}
