using System;
using System.Collections.Generic;
using System.Text;

namespace Ignite.DataStructures
{
    public class LinkedList
    {
        private Node root { get; set; }
        private Node tail { get; set; }
        private int count { get; set; }

        class Node
        {
            public int value { get; set; }
            public Node next { get; set; }

            public Node(int value)
            {
                this.value = value;
                next = null;
            }
        }

        /// <summary>
        /// Adds num to end of linked list
        /// </summary>
        /// <param name="i"></param>
        public void Add(int num)
        {
            if (root == null)
            {
                root = new Node(num);
                tail = root;
            }

            tail.next = new Node(num);
            tail = tail.next;
            count++;
        }

        /// <summary>
        /// Returns the number of elements currently in the list
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return count;
        }

        public void Remove(int num)
        {
            var currentNode = root;
            var previousNode = root;
            while (currentNode != null)
            {
                if (currentNode.value == num)
                {
                    break;
                }
                previousNode = currentNode;
                currentNode = currentNode.next;
            }

            
        }

        /// <summary>
        /// Returns true/false value depending on whether num is contained in list
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool Contains(int num)
        {
            var currentNode = root;
            var inList = false;
            while (currentNode != null)
            {
                if (currentNode.value == num)
                {
                    inList = true;
                    break;
                }
                currentNode = currentNode.next;
            }
            return inList;
        }
    }
}
