using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Trie
{
    public class TrieNode
    {

        public class ChildrenList : List<TrieNode>
		{
            public bool Contains(char c) 
            {
                return this.Select(x => x.Letter == c) != null;
            }

            public TrieNode this[char c]
            {
                get { return this.FirstOrDefault(x => x.Letter == c); }
            }
        }

        public ChildrenList Children;
        public bool IsLeaf { get; set; }
        public char Letter { get; private set; }

        public TrieNode(char c)
        {
            Children = new ChildrenList();
            this.IsLeaf = false;
            this.Letter = c;
        }

        public bool HasChild(char c) 
        {
            //return Children.Select(x => x.Letter == c) != null;

            foreach (var n in Children)
                if (n.Letter == c)
                    return true;
            return false;
        }

        public TrieNode GetChild(char c)
        {
            return Children.FirstOrDefault(x => x.Letter == c);
        }
    }
}
