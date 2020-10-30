using System.Collections.Generic;
using System.Linq;

namespace Trie
{
    public class TrieNode
    {

        public class ChildrenList : List<TrieNode>
        {
            public bool Contains(char c) => this.FirstOrDefault(x => x.Letter == c) != null;
            public TrieNode this[char c] => this.FirstOrDefault(x => x.Letter == c);
        }

        public ChildrenList Children;
        public bool IsLeaf { get; set; }
        public char Letter { get; private set; }

        public TrieNode(char c)
        {
            this.Children = new ChildrenList();
            this.IsLeaf = false;
            this.Letter = c;
        }
    }
}
