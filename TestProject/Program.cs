using System.Collections.Generic;
using WhatTheFind;

namespace TestProject
{
    public class Program
    {
        public class Node
        {
            public int Value { get; set; }
            public IEnumerable<Node> Children { get; set; }
        }

        static void Main(string[] args)
        {
            var nodeB = new Node { Value = 1 };
            var nodeC = new Node { Value = 2 };
            var nodeA = new Node { Value = 0, Children = new List<Node> { nodeB, nodeC } };

            nodeA.FindWhere(x => x.Value == 3, x => x.Children);
        }
    }
}
