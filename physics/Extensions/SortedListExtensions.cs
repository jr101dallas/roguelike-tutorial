using System.Collections.Generic;

namespace Physics
{
    public static class SortedListExtensions
    {
        //https://stackoverflow.com/questions/1613004/get-last-element-in-a-sorteddictionary
        public static KeyValuePair<K, V> Max<K, V>(this SortedList<K, V> dict)
        {
            var index = dict.Count - 1; //O(1) again
            return new KeyValuePair<K, V>(dict.Keys[index], dict.Values[index]);
        }

        //https://stackoverflow.com/questions/1613004/get-last-element-in-a-sorteddictionary
        public static KeyValuePair<K, V> Min<K, V>(this SortedList<K, V> dict)
        {
            return new KeyValuePair<K, V>(dict.Keys[0], dict.Values[0]); //is O(1)
        }
    }
}