using System.Collections.Generic;

namespace TreeViewManually.Data
{
    public class Node
    {
        public string Value { get; set; }
        public List<Node> Children { get; set; }
    }
}