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

        public void AddLast(int num)
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

        public void AddFirst(int num)
        {
            if (root == null)
            {
                root = new Node(num);
                tail = root;
            }
            else
            {
                var newNode = new Node(num);
                newNode.next = root;
                root = newNode;
            }

            count++;
        }

        public bool Remove(int num)
        {
            var removed = false;
            var currentNode = root;

            if (currentNode.value == num)
            {
                root = currentNode.next;
                currentNode.next = null;
                removed = true;

                if (count == 1)
                {
                    tail = null;
                }
            }
            else
            {
                Node previousNode = null;
                while (currentNode.value != num && currentNode != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.next;
                }

                if (currentNode != null)
                {
                    previousNode.next = currentNode.next;

                    if (currentNode.next == null && currentNode.value == tail.value)
                    {
                        tail = previousNode;
                    }
                    currentNode.next = null;
                    
                    removed = true;
                }
            }

            count--;
            return removed;
        }
    }
}
