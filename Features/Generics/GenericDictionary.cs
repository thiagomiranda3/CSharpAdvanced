using System.Collections;
using System.Collections.Generic;

namespace Features.Generics
{
    public class GenericDictionary<TKey, TValue>
    {
        public Dictionary<TKey, TValue> dictionary;

        public GenericDictionary()
        {
            dictionary = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public TValue this[TKey key]
        {
            get
            {
                TValue value;
                dictionary.TryGetValue(key, out value);
                return value;
            }
        }
    }
}