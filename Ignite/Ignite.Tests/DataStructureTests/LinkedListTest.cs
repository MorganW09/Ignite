using Ignite.DataStructures;
using System;
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

        [Fact]
        public void RemoveOnlyElementFromList()
        {
            var linkedList = new LinkedList();
            var element = 1;

            linkedList.AddLast(element);
            var removed = linkedList.Remove(element);

            Assert.True(removed);
            Assert.Equal(0, linkedList.count);
            Assert.Null(linkedList.root);
            Assert.Null(linkedList.tail);
        }

        [Fact]
        public void RemoveFirstElementFromList()
        {
            var linkedList = new LinkedList();
            var firstElement = 1;
            var secondElement = 2;
            var thirdElement = 3;

            linkedList.AddLast(firstElement);
            linkedList.AddLast(secondElement);
            linkedList.AddLast(thirdElement);

            var removed = linkedList.Remove(firstElement);

            Assert.True(removed);
            Assert.Equal(2, linkedList.count);
            Assert.NotNull(linkedList.tail);

            //testing root
            Assert.NotNull(linkedList.root);
            Assert.Equal(secondElement, linkedList.root.value);
            Assert.NotNull(linkedList.root.next);

            //testing tail
            Assert.NotNull(linkedList.tail);
            Assert.Equal(thirdElement, linkedList.tail.value);
            Assert.Null(linkedList.tail.next);
            Assert.Equal(thirdElement, linkedList.root.next.value);
        }

        [Fact]
        public void RemoveMiddleElementFromList()
        {
            var linkedList = new LinkedList();
            var firstElement = 1;
            var secondElement = 2;
            var thirdElement = 3;

            linkedList.AddLast(firstElement);
            linkedList.AddLast(secondElement);
            linkedList.AddLast(thirdElement);

            var removed = linkedList.Remove(secondElement);

            Assert.True(removed);
            Assert.Equal(2, linkedList.count);
            Assert.NotNull(linkedList.tail);

            //testing root
            Assert.NotNull(linkedList.root);
            Assert.Equal(firstElement, linkedList.root.value);
            Assert.NotNull(linkedList.root.next);

            //testing tail
            Assert.NotNull(linkedList.tail);
            Assert.Equal(thirdElement, linkedList.tail.value);
            Assert.Null(linkedList.tail.next);
            Assert.Equal(thirdElement, linkedList.root.next.value);
        }

        [Fact]
        public void RemoveLastElementFromList()
        {
            var linkedList = new LinkedList();
            var firstElement = 1;
            var secondElement = 2;
            var thirdElement = 3;

            linkedList.AddLast(firstElement);
            linkedList.AddLast(secondElement);
            linkedList.AddLast(thirdElement);

            var removed = linkedList.Remove(thirdElement);

            Assert.True(removed);
            Assert.Equal(2, linkedList.count);
            Assert.NotNull(linkedList.tail);

            //testing root
            Assert.NotNull(linkedList.root);
            Assert.Equal(firstElement, linkedList.root.value);
            Assert.NotNull(linkedList.root.next);

            //testing tail
            Assert.NotNull(linkedList.tail);
            Assert.Equal(secondElement, linkedList.tail.value);
            Assert.Null(linkedList.tail.next);
            Assert.Equal(secondElement, linkedList.root.next.value);
        }

        [Fact]
        public void AttemptToRemoveNonElementFromList()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);

            var removed = linkedList.Remove(10);

            Assert.False(removed);
            Assert.Equal(4, linkedList.count);
        }

        [Fact]
        public void AddAfter_ThrowExceptionWhenNumNotInList()
        {
            var linkedList = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => linkedList.AddAfter(1, 2));
        }

        [Fact]
        public void AddAfter_AddElementToList()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(1);

            linkedList.AddAfter(1, 2);

            Assert.Equal(2, linkedList.count);
            Assert.Equal(1, linkedList.root.value);
            Assert.Equal(2, linkedList.root.next.value);
            Assert.Equal(2, linkedList.tail.value);
        }

        [Fact]
        public void AddAfter_AddAfterFirstElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);

            linkedList.AddAfter(1, 3);

            var first = linkedList.root;
            var second = first.next;
            var third = second.next;

            Assert.Equal(3, linkedList.count);
            Assert.Equal(1, first.value);
            Assert.Equal(3, second.value);
            Assert.Equal(2, third.value);
            Assert.Equal(2, linkedList.tail.value);
        }

        [Fact]
        public void AddAfter_AddAfterLastElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);

            linkedList.AddAfter(2, 3);

            var first = linkedList.root;
            var second = first.next;
            var third = second.next;

            Assert.Equal(3, linkedList.count);
            Assert.Equal(1, first.value);
            Assert.Equal(2, second.value);
            Assert.Equal(3, third.value);
            Assert.Equal(3, linkedList.tail.value);
        }

        [Fact]
        public void AddBefore_ThrowsExceptionWhenNumNotInList()
        {
            var linkedList = new LinkedList();

            Assert.Throws<InvalidOperationException>(() => linkedList.AddBefore(1, 2));
        }

        [Fact]
        public void AddBefore_AddBeforeMiddleElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(1);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            linkedList.AddBefore(3, 2);


            var first = linkedList.root;
            var second = first.next;
            var third = second.next;
            var fourth = third.next;
            Assert.Equal(4, linkedList.count);
            Assert.Equal(1, first.value);
            Assert.Equal(2, second.value);
            Assert.Equal(3, third.value);
            Assert.Equal(4, fourth.value);
            Assert.Equal(4, linkedList.tail.value);
        }

        [Fact]
        public void AddBefore_AddBeforeLastElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(4);

            linkedList.AddBefore(4, 3);

            var first = linkedList.root;
            var second = first.next;
            var third = second.next;
            var fourth = third.next;
            Assert.Equal(4, linkedList.count);
            Assert.Equal(1, first.value);
            Assert.Equal(2, second.value);
            Assert.Equal(3, third.value);
            Assert.Equal(4, fourth.value);
            Assert.Equal(4, linkedList.tail.value);
        }

        [Fact]
        public void AddBefore_AddBeforeFirstElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddFirst(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            linkedList.AddBefore(2, 1);

            var first = linkedList.root;
            var second = first.next;
            var third = second.next;
            var fourth = third.next;
            Assert.Equal(4, linkedList.count);
            Assert.Equal(1, first.value);
            Assert.Equal(2, second.value);
            Assert.Equal(3, third.value);
            Assert.Equal(4, fourth.value);
            Assert.Equal(4, linkedList.tail.value);
        }

        [Fact]
        public void Clear_ClearLinkedListWithSingleElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(1);

            linkedList.Clear();

            Assert.Equal(0, linkedList.count);
            Assert.Null(linkedList.root);
            Assert.Null(linkedList.tail);
        }

        [Fact]
        public void Clear_CleanUpMemoryReferences()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            var first = linkedList.root;
            var second = first.next;
            var third = second.next;
            var fourth = third.next;

            linkedList.Clear();
            
            Assert.Null(first.next);
            Assert.Null(second.next);
            Assert.Null(third.next);
            Assert.Null(fourth.next);
        }

        [Fact]
        public void Contains_CheckEmptyList()
        {
            var linkedList = new LinkedList();

            var contains = linkedList.Contains(1);

            Assert.False(contains);
        }

        [Fact]
        public void Contains_CheckListWithOneElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(1);

            var contains = linkedList.Contains(1);

            Assert.True(contains);
        }

        [Fact]
        public void Contains_CheckListWithTenElements()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(23);
            linkedList.AddLast(76);
            linkedList.AddLast(23);
            linkedList.AddLast(77);
            linkedList.AddLast(92);
            linkedList.AddLast(12);
            linkedList.AddLast(54);
            linkedList.AddLast(34);
            linkedList.AddLast(96);

            var contains = linkedList.Contains(92);

            Assert.True(contains);
        }

        [Fact]
        public void CopyTo_ThrowsExceptionWhenArrayNull()
        {
            var linkedList = new LinkedList();
            Assert.Throws<ArgumentNullException>(() => linkedList.CopyTo(null, 0));
        }

        [Fact]
        public void CopyTo_ThrowsExceptionWhenIndexLessThan0()
        {
            var linkedList = new LinkedList();
            var intArray = new int[1];

            Assert.Throws<ArgumentOutOfRangeException>(() => linkedList.CopyTo(intArray, -1));
        }

        [Fact]
        public void CopyTo_ThrowsExceptionWhenIndexGreaterThanLength()
        {
            var linkedList = new LinkedList();
            var intArray = new int[1];

            Assert.Throws<ArgumentOutOfRangeException>(() => linkedList.CopyTo(intArray, 1));
        }

        [Fact]
        public void CopyTo_ThrowsExceptionArrayNotLongEnoughForList()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            var intArray = new int[1];

            Assert.Throws<ArgumentException>(() => linkedList.CopyTo(intArray, 0));
        }


        [Fact]
        public void CopyTo_CopyOneElement()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(10);

            var intArray = new int[linkedList.count];
            linkedList.CopyTo(intArray, 0);

            Assert.Equal(10, intArray[0]);
        }


        [Fact]
        public void CopyTo_CopyThreeElements()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            var intArray = new int[linkedList.count];
            linkedList.CopyTo(intArray, 0);

            Assert.Equal(10, intArray[0]);
            Assert.Equal(20, intArray[1]);
            Assert.Equal(30, intArray[2]);
        }


        [Fact]
        public void CopyTo_CopyThreeElementsNotStartingAt0()
        {
            var linkedList = new LinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);
            linkedList.AddLast(60);

            var offset = 3;
            var intArray = new int[linkedList.count + offset];
            linkedList.CopyTo(intArray, offset);

            Assert.Equal(10, intArray[0 + offset]);
            Assert.Equal(20, intArray[1 + offset]);
            Assert.Equal(30, intArray[2 + offset]);
            Assert.Equal(40, intArray[3 + offset]);
            Assert.Equal(50, intArray[4 + offset]);
            Assert.Equal(60, intArray[5 + offset]);
        }


        [Fact]
        public void CopyTo_NoExceptionWhenCopyingEmptyList()
        {
            var linkedList = new LinkedList();
            var intArray = new int[0];
            
            linkedList.CopyTo(intArray, 0);
        }
    }
}
