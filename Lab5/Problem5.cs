using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Problem5
    {
        public void dictionaryMethods()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            myDictionary.Add(1, "Apple");
            myDictionary.Add(2, "Banana");
            myDictionary.Add(3, "Cherry");
            DisplayDictionary(myDictionary);

            Console.WriteLine("\nRemoving key 2 from dictionary.");
            myDictionary.Remove(2);
            DisplayDictionary(myDictionary);


            Console.WriteLine($"\nContainsKey(3): {myDictionary.ContainsKey(3)}");

            string valueToCheck = "Apple";
            bool hasValue = myDictionary.ContainsValue(valueToCheck);
            Console.WriteLine($"ContainsValue(\"{valueToCheck}\"): {hasValue}");

            Console.WriteLine("\nClearing the dictionary.");
            myDictionary.Clear();
            Console.WriteLine("Dictionary after clearing:");
            DisplayDictionary(myDictionary);
        }
        public void DisplayDictionary(Dictionary<int, string> dictionary)
        {
            if (dictionary.Count == 0)
            {
                Console.WriteLine("The dictionary is empty.");
            }
            else
            {
                foreach (var kvp in dictionary)
                {
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                }
            }
        }
    }
}
