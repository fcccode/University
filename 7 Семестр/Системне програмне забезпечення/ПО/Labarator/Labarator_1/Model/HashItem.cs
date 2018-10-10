using System;

namespace Labarator_1.Model
{
    public class HashItem
    {
        public string Key { get; private set; }
        public IdentityInfo Value { get; private set; }

        public HashItem(string key, IdentityInfo val)
        {
           
            if (string.IsNullOrEmpty(key))
            { throw new ArgumentNullException(nameof(key)); }

            if (val == null)
            { throw new ArgumentNullException(nameof(val)); }

            Key = key;
            Value = val;
        }
    }
}
