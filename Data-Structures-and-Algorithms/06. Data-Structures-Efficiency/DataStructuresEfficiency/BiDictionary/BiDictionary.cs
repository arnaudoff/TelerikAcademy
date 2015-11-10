namespace BiDictionary
{
    using System;
    using System.Collections.Generic;

    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, V>
    {
        private readonly MultiDictionary<K1, V> firstDictionary;
        private readonly MultiDictionary<K2, V> secondDictionary;
        private readonly MultiDictionary<Tuple<K1, K2>, V> mergedDictionary;

        public BiDictionary(bool allowDuplicateValues)
        {
            this.firstDictionary = new MultiDictionary<K1, V>(allowDuplicateValues);
            this.secondDictionary = new MultiDictionary<K2, V>(allowDuplicateValues);
            this.mergedDictionary = new MultiDictionary<Tuple<K1, K2>, V>(allowDuplicateValues);
        }

        public void Add(K1 firstKey, K2 secondKey, V value)
        {
            this.firstDictionary.Add(firstKey, value);
            this.secondDictionary.Add(secondKey, value);
            this.mergedDictionary.Add(new Tuple<K1, K2>(firstKey, secondKey), value);
        }

        public ICollection<V> FindByFirstKey(K1 key)
        {
            return this.firstDictionary[key];
        }

        public ICollection<V> FindBySecondKey(K2 key)
        {
            return this.secondDictionary[key];
        }

        public ICollection<V> FindByBothKeys(K1 firstKey, K2 secondKey)
        {
            return this.mergedDictionary[new Tuple<K1, K2>(firstKey, secondKey)];
        }
    }
}
