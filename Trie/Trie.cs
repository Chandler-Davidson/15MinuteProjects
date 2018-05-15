namespace Trie
{
	public class Trie
	{
		public TrieNode Root { get; private set; }

		public Trie()
		{
			this.Root = new TrieNode(' ');
		}

		public void Insert(string str)
		{
			TrieNode temp = Root;

			foreach (char c in str)
			{
				if (!temp.Children.Contains(c))
					temp.Children.Add(new TrieNode(c));

				temp = temp.Children[c];
			}

			temp.IsLeaf = true;
		}

		public bool Search(string str)
		{
			var temp = Root;

			foreach (char c in str)
			{
				if (!temp.Children.Contains(c))
					return false;

				temp = temp.Children[c];
			}

			return (temp != null && temp.IsLeaf);
		}
	}
}
