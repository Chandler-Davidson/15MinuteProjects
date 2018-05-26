using System;
using System.Collections.Generic;
using System.IO;

namespace Trie
{
	class MainClass
	{
		private const string filePath1 = @"C:\Users\davidsoncha\Documents\GitHub\Trie\Trie\keys.txt";
		private const string filePath2 = @"C:\Users\davidsoncha\Documents\GitHub\Trie\Trie\wrong.txt";

		public static void Main(string[] args)
		{
			var trie = new Trie();

			var keys = ReadFile(filePath1);
			var wrongKeys = ReadFile(filePath2);

			foreach (var s in keys)
				trie.Insert(s);

			foreach (var s in keys)
				Console.WriteLine(trie.Search(s) ? "Found: " + s : "Did not find: " + s);

			foreach (var s in wrongKeys)
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
