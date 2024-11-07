using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Problem6
    {
        public void hashMapMethod()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("ID1", "John");
            hashtable.Add("ID2", 222);
            hashtable.Add("ID3", true);

            Console.WriteLine("Hashtable after adding elements:");
            PrintHashtable(hashtable);

            hashtable.Remove("ID2");
            Console.WriteLine("\nHashtable after removing key 'ID2':");
            PrintHashtable(hashtable);

            // Checking if a key exists
            bool containsKey = hashtable.ContainsKey("ID1");
            Console.WriteLine($"\nHashtable contains key 'ID1': {containsKey}");

            // Checking if a value exists
            bool containsValue = hashtable.ContainsValue("Bob");
            Console.WriteLine($"Hashtable contains value 'Bob': {containsValue}");

            // Clearing all key-value pairs
            hashtable.Clear();
            Console.WriteLine("\nHashtable after clearing all elements:");
            PrintHashtable(hashtable);
        }
        public void PrintHashtable(Hashtable hashtable)
        {
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            if (hashtable.Count == 0)
            {
                Console.WriteLine("Hashtable is empty.");
            }
        }
    }
}
