using System;
using System.Collections.Generic;
using System.IO;

namespace Trie
{
    class MainClass
    {
        private const string filePath1 = @"..\..\KeySet1.txt";
        private const string filePath2 = @"..\..\KeySet1.txt";

        public static void Main(string[] args)
        {
            var trie = new Trie();

            var keys = ReadFile(filePath1);
            var alternateKeys = ReadFile(filePath2);

            foreach (var s in keys)
                trie.Insert(s);

            foreach (var s in keys)
                Console.WriteLine(trie.Search(s) ? "Found: " + s : "Did not find: " + s);

            foreach (var s in alternateKeys)
                Console.WriteLine(trie.Search(s) ? "Found: " + s : "Did not find: " + s);
        }

        public static string[] ReadFile(string path)
        {
            string[] words = new string[100];

            using (var reader = new StreamReader(path))
                words = reader.ReadLine().Split(' ');

            return words;
        }

    }
}
