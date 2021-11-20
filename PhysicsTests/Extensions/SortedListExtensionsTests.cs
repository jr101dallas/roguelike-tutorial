using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Physics;
using Physics.Items;

namespace PhysicsTest
{
    [TestClass]
    public class SortedListExtensionsTests
    {
        [TestMethod]
        public void MaxWorksForContinuousKeys()
        {
            var sList = new SortedList<int,Item>();
            sList.Add(0, new Item());
            sList.Add(1, new Item());
            sList.Add(2, new Item());
            Assert.AreEqual(2, sList.Max().Key);
        }

        [TestMethod]
        public void MaxWorksForSparseKeys()
        {
            var sList = new SortedList<int,Item>();
            sList.Add(3, new Item());
            sList.Add(6, new Item());
            sList.Add(9, new Item());
            Assert.AreEqual(9, sList.Max().Key);
        }

        [TestMethod]
        public void MinWorksForContinuousKeys()
        {
            var sList = new SortedList<int,Item>();
            sList.Add(0, new Item());
            sList.Add(1, new Item());
            sList.Add(2, new Item());
            Assert.AreEqual(0, sList.Min().Key);
        }

        [TestMethod]
        public void MinWorksForSparseKeys()
        {
            var sList = new SortedList<int,Item>();
            sList.Add(3, new Item());
            sList.Add(6, new Item());
            sList.Add(9, new Item());
            Assert.AreEqual(3, sList.Min().Key);
        }
    }
}
