using Ignite.DataStructures;
using Xunit;

namespace Ignite.Tests.DataStructureTests
{
    public class LinkedListTest
    {

        [Fact]
        public void AddLastElementToLinkedList()
        {
            var linkedList = new LinkedList();
            var element = 1;

            linkedList.AddLast(element);

            Assert.NotNull(linkedList.root);
            Assert.Equal(element, linkedList.root.value);
            Assert.Null(linkedList.root.next);
            Assert.NotNull(linkedList.tail);
        }

        [Fact]
        public void AddLastElementToLinkedListUpdateCount()
        {
            var linkedList = new LinkedList();
            var element = 1;

            linkedList.AddLast(element);
            Assert.Equal(1, linkedList.count);
        }

        [Fact]
        public void AddLastTwoElementsToLinkedList()
        {
            var linkedList = new LinkedList();

            linkedList.AddLast(1);
            linkedList.AddLast(2);

            Assert.Equal(2, linkedList.count);

            //root tests
            Assert.Equal(1, linkedList.root.value);
            Assert.NotNull(linkedList.root.next);

            //tail tests
            Assert.NotNull(linkedList.tail);
            Assert.Equal(2, linkedList.tail.value);
            Assert.Null(linkedList.tail.next);
        }

        [Fact]
        public void AddLastFourElementsToLinkedList()
        {
            var linkedList = new LinkedList();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);


            Assert.Equal(4, linkedList.count);

            //root tests
            var firstElement = linkedList.root;
            Assert.Equal(1, firstElement.value);
            Assert.NotNull(firstElement.next);

            //2 tests
            var secondElement = firstElement.next;
            Assert.NotNull(secondElement);
            Assert.Equal(2, secondElement.value);
            Assert.NotNull(secondElement.next);

            //3 tests
            var thirdElement = secondElement.next;
            Assert.NotNull(thirdElement);
            Assert.Equal(3, thirdElement.value);
            Assert.NotNull(thirdElement.next);

            //4 tests
            var fourthElement = thirdElement.next;
            Assert.NotNull(fourthElement);
            Assert.Equal(4, fourthElement.value);
            Assert.Null(fourthElement.next);

            //tail tests
            Assert.NotNull(linkedList.tail);
            Assert.Equal(4, linkedList.tail.value);
            Assert.Null(linkedList.tail.next);
        }

        [Fact]
        public void AddFirstElementToList()
        {
            var linkedList = new LinkedList();
            var element = 1;

            linkedList.AddFirst(element);

            Assert.NotNull(linkedList.root);
            Assert.NotNull(linkedList.tail);
            Assert.Equal(element, linkedList.root.value);
            Assert.Equal(element, linkedList.tail.value);
            Assert.Equal(1, linkedList.count);
        }

        [Fact]
        public void AddFirstTwoElementsToList()
        {
            var linkedList = new LinkedList();
            var firstElement = 1;
            var secondElement = 2;

            linkedList.AddFirst(firstElement);
            linkedList.AddFirst(secondElement);

            Assert.NotNull(linkedList.root);
            Assert.NotNull(linkedList.tail);
            Assert.Equal(2, linkedList.count);

            //first element
            Assert.NotNull(linkedList.tail);
            Assert.Equal(firstElement, linkedList.tail.value);
            Assert.Null(linkedList.tail.next);

            //second element
            Assert.NotNull(linkedList.root);
            Assert.Equal(secondElement, linkedList.root.value);
            Assert.NotNull(linkedList.root.next);
            Assert.Equal(firstElement, linkedList.root.next.value);
            Assert.Null(linkedList.tail.next);
        }

        [Fact]
        public void AddFirstFourElementsToList()
        {
            var linkedList = new LinkedList();
            var firstElement = 1;
            var secondElement = 2;
            var thirdElement = 3;
            var fourthElement = 4;

            linkedList.AddFirst(firstElement);
            linkedList.AddFirst(secondElement);
            linkedList.AddFirst(thirdElement);
            linkedList.AddFirst(fourthElement);

            //firstNode
            var firstNode = linkedList.root;
            Assert.Equal(fourthElement, firstNode.value);

            //secondNode
            var secondNode = firstNode.next;
            Assert.Equal(thirdElement, secondNode.value);

            //thirdNode
            var thirdNode = secondNode.next;
            Assert.Equal(secondElement, thirdNode.value);

            //fourthNode
            var fourthNode = thirdNode.next;
            Assert.Equal(firstElement, fourthNode.value);
        }
    }
}
