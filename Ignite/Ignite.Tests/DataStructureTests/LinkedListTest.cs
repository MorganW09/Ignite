using Ignite.DataStructures;
using Xunit;

namespace Ignite.Tests.DataStructureTests
{
    public class LinkedListTest
    {

        [Fact]
        public void AddElementsToLinkedList()
        {
            var linkedList = new LinkedList();
            var element = 1;

            linkedList.Add(element);

            Assert.NotNull(linkedList.root);
            Assert.Equal(element, linkedList.root.value);
            Assert.Null(linkedList.root.next);
            Assert.NotNull(linkedList.tail);
        }

        [Fact]
        public void AddElementsToLinkedListUpdateCount()
        {
            var linkedList = new LinkedList();
            var element = 1;

            linkedList.Add(element);
            Assert.Equal(1, linkedList.count);
        }

        [Fact]
        public void AddTwoElementsToLinkedList()
        {
            var linkedList = new LinkedList();

            linkedList.Add(1);
            linkedList.Add(2);

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
        public void AddFourElementsToLinkedList()
        {
            var linkedList = new LinkedList();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);


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
    }
}
