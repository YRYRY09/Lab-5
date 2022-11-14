using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerator IEnumerable;
            GetEnumerator();
            {
                return GetEnumerator();
            }
        }

        private static IEnumerator<KeyValuePair<Tkey, Tval>> GetEnumerator()
        {
            for (int i = 0; i < keysArray.Length; i++)
                yield return new KeyValuePair<Tkey, Tval>(keysArray[i], valsArray[i]);
        }
    }
}
