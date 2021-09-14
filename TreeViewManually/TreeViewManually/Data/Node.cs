using System;
using System.Collections.Generic;

namespace TreeViewManually.Data
{
    public class Node
    {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Value { get; set; }
        public List<Node> Children { get; set; }
    }

    public static class TreeView 
    {
        public static List<Node> SampleData = new()
        {
            new Node()
            {
                Value = "Shops",
                Children = new List<Node>()
                {
                    new Node()
                    {
                        Value = "Grocery Store",

                    },
                    new Node()
                    {
                        Value = "DIY",

                    },
                    new Node()
                    {
                        Value = "Supermarket",
                        Children = new List<Node>()
                        {
                            new Node
                            {
                                Value = "Fishing Department"
                            },
                            new Node
                            {
                                Value = "Sports Department"
                            }
                        }
                    },
                    new Node()
                    {
                        Value = "Others",

                    },
                }
            },
            new Node()
            {
                Value = "Services",
                Children = new List<Node>()
                {
                    new Node()
                    {
                        Value = "Barber",

                    },
                    new Node()
                    {
                        Value = "Repair Shop",

                    },
                    new Node()
                    {
                        Value = "Others",

                    },
                }
            },
        };
    }

}