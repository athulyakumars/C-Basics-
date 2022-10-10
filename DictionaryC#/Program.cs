using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict.Add(2, "Orange");
            dict.Add(3, "Avocado");
            dict.Add(4, "DragonFruit");
            dict.Add(5, "Banana");
            dict.Add(6, "Grapes");
            dict.Add(7, "Plum");
            Console.WriteLine(dict[3]);

            // Serach a Key
            if(!dict.ContainsKey(5))
            {
                dict[5] = "Lime";
            }
            if (!dict.ContainsKey(8))
            {
                dict[8] = "Cherry";
            }

            // Display Data in Dictionary
            foreach(KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.Key + " | " + item.Value );
            }

            Hashtable hash = new Hashtable();
            hash.Add(1, "CAT");
            hash.Add("Two", "DOG");

            foreach(DictionaryEntry item1 in hash)
            {
                Console.WriteLine(item1.Key + " || " + item1.Value);
            }

        }
    }
}
