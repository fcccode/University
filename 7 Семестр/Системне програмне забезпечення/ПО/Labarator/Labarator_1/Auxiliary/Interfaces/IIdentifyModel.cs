
using Labarator_1.Model;
using System.Collections.Generic;

namespace Labarator_1.Auxiliary.Interfaces
{
    public interface IIdentifyModel
    {
        IReadOnlyCollection<KeyValuePair<uint, List<HashItem>>> Items { get; }
        void Insert(string _key, IdentityInfo _value);
        void Remove(string _key);
        IdentityInfo FindItem(string _key);
    }
}
