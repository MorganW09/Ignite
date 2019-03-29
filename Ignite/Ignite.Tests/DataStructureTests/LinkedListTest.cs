using Ignite.DataStructures;
using Xunit;

namespace Ignite.Tests.DataStructureTests
{
    public class LinkedListTest
    {
        private LinkedList buildLinkedList(int greatestElement)
        {
            var linkedList = new LinkedList();
            for (int i = 1; i <= greatestElement; i++)
            {
                linkedList.Add(i);
            }
            return linkedList;
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(10, 10)]
        [InlineData(100, 100)]
        public void AddItemsToList(int greatestElement, int expected)
        {
            //Arrange
            var linkedList = buildLinkedList(greatestElement);

            //Act
            var actual = linkedList.Count();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 1, 1)]
        [InlineData(3, 3, 2)]
        public void RemoveElementsFromList(int greatestElement, int elementToRemove, int expectedCount)
        {
            //Arrange
            var linkedList = buildLinkedList(greatestElement);

            //Act
            linkedList.Remove(elementToRemove);
            var count = linkedList.Count();

            //Assert
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(1, 1, true)]
        [InlineData(10, 4, true)]
        [InlineData(5, 10, false)]
        public void ListContainsElement(int greatestElement, int elementToCheck, bool expected)
        {
            //Arrange 
            var linkedList = buildLinkedList(greatestElement);

            //Act
            var inList = linkedList.Contains(elementToCheck);

            //Assert
            Assert.Equal(expected, inList);
        }
    }
}
