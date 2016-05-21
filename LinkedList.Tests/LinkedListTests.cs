using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinkedList.Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void ShouldAddItemToFirst()
        {
            var sut = new LinkedList<int>();
            var addedItem = 2;

            sut.Add(5);
            sut.AddFirst(addedItem);

            Assert.That(sut.Head.Value.Equals(addedItem));
            Assert.That(sut.Size().Equals(2));
        }

        [Test]
        public void ShouldAddItem()
        {
            var sut = new LinkedList<int>();
            var item = 5;

            sut.Add(3);
            sut.Add(item);

            var currentItem = sut.Head;
            while (currentItem.Next != null)
            {
                currentItem = currentItem.Next;
            }

            Assert.That(currentItem.Value.Equals(item));
            Assert.That(sut.Size().Equals(2));

        }

        [Test]
        public void ShouldRemoveFirstItem()
        {
            var sut = new LinkedList<int>();
            var valueToCheck = 7;
            sut.Add(2);
            sut.Add(7);

            sut.RemoveFirst();

            Assert.That(sut.Head.Value.Equals(valueToCheck));
            Assert.That(sut.Size().Equals(1));
       
        }

        [Test]
        public void ShouldRemoveItem()
        {
            var sut = new LinkedList<int>();
            var valueToCheck = 4;

            sut.Add(8);
            sut.Add(valueToCheck);

            sut.Remove(0);

            Assert.That(sut.Head.Value.Equals(valueToCheck));
            Assert.That(sut.Size().Equals(1));
            
        }
    }
}
