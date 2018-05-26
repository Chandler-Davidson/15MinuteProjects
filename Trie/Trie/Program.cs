using System;
using System.Collections.Generic;

namespace Trie
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var t = new Trie();
            Console.WriteLine(t.Root.Children);
            Console.WriteLine(t.Root.Children.Contains('a'));


            //string[] keys = {"the", "a", "there", "answer", "any",
            //             "by", "bye", "their"};

            //string[] output = { "Not present in trie", "Present in trie" };

            //var t = new Trie();

            //for (int i = 0; i < keys.Length; i++)
            //    t.Insert(keys[i]);

            //var str = t.Search("the") ? "Found it!" : "nope";

            //Console.WriteLine(str);
        }
                
    }
}
