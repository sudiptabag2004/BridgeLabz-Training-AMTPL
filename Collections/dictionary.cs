using System;
using System.Collections.Generic;

namespace Practice
{
    public class Dictionary1
    {
        public static void Run()
        {
            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("rahul_01","Rahul");
            dictionary.Add("Risu46","Risha");
            dictionary.Add("Ronthedon","Ron");
            dictionary.Add("Raul_myname","Raul");

            
            dictionary.Remove("Risu46");
            
            if (dictionary.ContainsKey("rahul_01"))
            {
                Console.WriteLine(dictionary["rahul_01"]);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}