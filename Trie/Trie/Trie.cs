﻿using System;
namespace Trie
{
    public class Trie
    {
        public TrieNode Root { get; private set; }

        public Trie()
        {
            this.Root = new TrieNode(' ');
        }

   //     public void Insert(string str)
   //     {
   //         TrieNode temp = Root;

   //         foreach (char c in str)
   //         {
   //             if (!temp.HasChild(c))
   //                 temp.Children.Add(new TrieNode(c));

   //             temp = temp.GetChild(c);
			//}

        //    temp.IsLeaf = true;
        //}

        public void Insert(string str)
        {
            TrieNode temp = Root;

            foreach (char c in str)
            {
                Console.WriteLine(temp);
                Console.WriteLine(temp.Children);
                Console.WriteLine(temp.Children.Contains(c));


                if (!temp.Children.Contains(c))
                    temp.Children.Add(new TrieNode(c));

                temp = temp.Children[c];
            }

			temp.IsLeaf = true;
        }

        //public bool Search(string str)
        //{
        //    var temp = Root;

        //    foreach (char c in str)
        //    {
        //        if (!temp.HasChild(c))
        //            return false;
        //        temp = temp.GetChild(c);
        //    }

        //    return (temp != null && temp.IsLeaf);
        //}

        public bool Search(string str)
        {
            var temp = Root;

            foreach(char c in str) 
            {
                if (!temp.Children.Contains(c))
                    return false;

                temp = temp.Children[c];
            }

            return (temp != null && temp.IsLeaf);
        }

    }
}
