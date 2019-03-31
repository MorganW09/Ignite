using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("Ignite.Tests")]
namespace Ignite.DataStructures
{
    public class LinkedList //: IEnumerable<int>
    {
        internal Node root { get; set; }
        internal Node tail { get; set; }
        internal int count { get; set; }

        internal class Node
        {
            public int value { get; set; }
            public Node next { get; set; }

            public Node(int value)
            {
                this.value = value;
                next = null;
            }
        }

        public void Add(int num)
        {
            if (root == null)
            {
                root = new Node(num);
                tail = root;
            }
            else
            {
                tail.next = new Node(num);
                tail = tail.next;
            }

            count++;
        }
    }
}
